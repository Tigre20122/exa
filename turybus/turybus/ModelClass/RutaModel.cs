using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using turybus.Data;
using turybus.Models;

namespace turybus.ModelClass
{
    public class RutaModel
    {
        private readonly ApplicationDbContext _context;

        public RutaModel(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public  List<IdentityError> guardarRuta( string nombre , string descripcion, string estado)
        {
            var errorList = new List<IdentityError>();
            var ruta = new Ruta
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Estado = Convert.ToBoolean(estado)
            };
            _context.Add(ruta);
             _context.SaveChangesAsync();
            errorList.Add(new IdentityError
            {
                Code = "Save",
                Description = "Save"
            });
            return errorList;
        }

        public List<object[]> Lista_Ruta_Model()
        {
            List<object[]> listaRegresa = new List<object[]>();
            string dato = "";

            var ruta = _context.Rutas.ToList();

            foreach (var item in ruta)
            {
                dato += "<tr>" +
                    "<td>" + item.Nombre + "</td>" +
                    "<td>" + item.Descripcion + "</td>" +
                    "<td>" + item.Estado + "</td>" +
                    "<td>  <a data-toggle='modal' data-target='#Ingreso_Hospital' " +
                    "onclick ='un_Hospital(" + item.IdRuta + ")' " +
                    "class='btn btn-primary'>Edit</a> |" +
                    "<a onclick='eliminar_hospital(" + item.IdRuta + ")'" +
                    "class='btn btn-danger'>Delete</a></td>" +
                    "</tr>";
            }
            object[] objeto = { dato };
            listaRegresa.Add(objeto);
            return listaRegresa;
        }


    }
}
