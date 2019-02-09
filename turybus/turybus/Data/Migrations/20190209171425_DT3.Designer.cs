﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using turybus.Data;

namespace turybus.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190209171425_DT3")]
    partial class DT3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("turybus.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("turybus.Models.Boleto", b =>
                {
                    b.Property<int>("IdBoleto")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Actividad")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("HoraLLegada")
                        .IsRequired();

                    b.Property<string>("HoraSalida")
                        .IsRequired();

                    b.Property<int>("IdRuta");

                    b.Property<int>("IdVehiculo");

                    b.Property<double>("Importe");

                    b.Property<string>("Parada")
                        .IsRequired();

                    b.HasKey("IdBoleto");

                    b.HasIndex("IdRuta");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Boletos");
                });

            modelBuilder.Entity("turybus.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("turybus.Models.Conductor", b =>
                {
                    b.Property<int>("IdConductor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("IdConductor");

                    b.ToTable("Conductors");
                });

            modelBuilder.Entity("turybus.Models.Revision", b =>
                {
                    b.Property<int>("IdRevision")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired();

                    b.Property<string>("Diagnostico")
                        .IsRequired();

                    b.Property<string>("Fecha")
                        .IsRequired();

                    b.Property<int>("IdVehiculo");

                    b.Property<string>("Observacion")
                        .IsRequired();

                    b.Property<string>("Tiempo")
                        .IsRequired();

                    b.HasKey("IdRevision");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Revisions");
                });

            modelBuilder.Entity("turybus.Models.Ruta", b =>
                {
                    b.Property<int>("IdRuta")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("IdRuta");

                    b.ToTable("Rutas");
                });

            modelBuilder.Entity("turybus.Models.Vehiculo", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caracteristicas")
                        .IsRequired();

                    b.Property<string>("Fabricante")
                        .IsRequired();

                    b.Property<int>("IdConductor");

                    b.Property<string>("Matricula")
                        .IsRequired();

                    b.Property<string>("Modelo")
                        .IsRequired();

                    b.Property<string>("NumeroPlazas")
                        .IsRequired();

                    b.HasKey("IdVehiculo");

                    b.HasIndex("IdConductor");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("turybus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("turybus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("turybus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("turybus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("turybus.Models.Boleto", b =>
                {
                    b.HasOne("turybus.Models.Ruta", "Ruta")
                        .WithMany()
                        .HasForeignKey("IdRuta")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("turybus.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("turybus.Models.Revision", b =>
                {
                    b.HasOne("turybus.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("turybus.Models.Vehiculo", b =>
                {
                    b.HasOne("turybus.Models.Conductor", "Conductor")
                        .WithMany()
                        .HasForeignKey("IdConductor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}