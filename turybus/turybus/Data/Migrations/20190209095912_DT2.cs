using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace turybus.Data.Migrations
{
    public partial class DT2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Conductors",
                columns: table => new
                {
                    IdConductor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductors", x => x.IdConductor);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caracteristicas = table.Column<string>(nullable: false),
                    Fabricante = table.Column<string>(nullable: false),
                    IdConductor = table.Column<int>(nullable: false),
                    Matricula = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    NumeroPlazas = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdVehiculo);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Conductors_IdConductor",
                        column: x => x.IdConductor,
                        principalTable: "Conductors",
                        principalColumn: "IdConductor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boletos",
                columns: table => new
                {
                    IdBoleto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Actividad = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    HoraLLegada = table.Column<string>(nullable: false),
                    HoraSalida = table.Column<string>(nullable: false),
                    IdRuta = table.Column<int>(nullable: false),
                    IdVehiculo = table.Column<int>(nullable: false),
                    Importe = table.Column<double>(nullable: false),
                    Parada = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletos", x => x.IdBoleto);
                    table.ForeignKey(
                        name: "FK_Boletos_Rutas_IdRuta",
                        column: x => x.IdRuta,
                        principalTable: "Rutas",
                        principalColumn: "IdRuta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boletos_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revisions",
                columns: table => new
                {
                    IdRevision = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: false),
                    Diagnostico = table.Column<string>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    IdVehiculo = table.Column<int>(nullable: false),
                    Observacion = table.Column<string>(nullable: false),
                    Tiempo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisions", x => x.IdRevision);
                    table.ForeignKey(
                        name: "FK_Revisions_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boletos_IdRuta",
                table: "Boletos",
                column: "IdRuta");

            migrationBuilder.CreateIndex(
                name: "IX_Boletos_IdVehiculo",
                table: "Boletos",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Revisions_IdVehiculo",
                table: "Revisions",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdConductor",
                table: "Vehiculos",
                column: "IdConductor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boletos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Revisions");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Conductors");
        }
    }
}
