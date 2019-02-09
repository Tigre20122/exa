using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using turybus.Data;
using turybus.Models;

namespace turybus.ModelClass
{
    public class ClienteModel
    {
        private readonly ApplicationDbContext _context;

        public ClienteModel (ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public List<IdentityError> guardarCliente(string cedula,string nombre, string apellido, string telefono)
        {
            var errorList = new List<IdentityError>();
            var cliente = new Cliente
            {
                Cedula = cedula,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono
            };
            _context.Add(cliente);
            _context.SaveChangesAsync();
            errorList.Add(new IdentityError
            {
                Code = "Save",
                Description = "Save"
            });
            return errorList;
        }

        public List<object[]> Lista_Cliente_Model()
        {
            List<object[]> listaRegresa = new List<object[]>();
            string dato = "";

            var cliente = _context.Clientes.ToList();

            foreach (var item in cliente)
            {
                dato += "<tr>" +
                    "<td>" + item.Cedula + "</td>" +
                    "<td>" + item.Nombre + "</td>" +
                    "<td>" + item.Apellido + "</td>" +
                    "<td>" + item.Telefono + "</td>" +
                    "</tr>";
            }
            object[] objeto = { dato };
            listaRegresa.Add(objeto);
            return listaRegresa;
        }
    }
}
