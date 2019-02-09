using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using turybus.Data;
using turybus.Models;

namespace turybus.ModelClass
{
    public class ConductorModel
    {
        private readonly ApplicationDbContext _context;
        public ConductorModel(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public List<IdentityError> guardarConductor(string cedula, string nombre, string apellido, string telefono,string direccion)
        {
            var errorList = new List<IdentityError>();
            var conductor= new Conductor
            {
                Cedula = cedula,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Direccion = direccion
            };
            _context.Add(conductor);
            _context.SaveChangesAsync();
            errorList.Add(new IdentityError
            {
                Code = "Save",
                Description = "Save"
            });
            return errorList;
        }
    }
}
