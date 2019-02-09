using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using turybus.Data;
using turybus.ModelClass;
using turybus.Models;

namespace turybus.Controllers
{
    public class ConductorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ConductorModel  conductorModel;


        public ConductorsController(ApplicationDbContext context)
        {
            _context = context;
            conductorModel = new ConductorModel(_context);
        }
        [Authorize(Roles = "Administrador")]

        public async Task<IActionResult> Index()
        {
            return View(await _context.Conductors.ToListAsync());
        }

        public async Task<List<Conductor>> MostrarAjax(int id)
        {
            List<Conductor> con = new List<Conductor>();
            var appPro = await _context.Conductors.SingleOrDefaultAsync(c => c.IdConductor == id);
            con.Add(appPro);
            return con;
        }

        public async Task<String> EliminarAjax(int id)
        {
            var rut = await _context.Conductors.SingleOrDefaultAsync(c => c.IdConductor== id);
            _context.Conductors.Remove(rut);
            await _context.SaveChangesAsync();
            return "delete";
        }


        public List<IdentityError> guardarConductor(string cedula, string nombre, string apellido, string telefono,string direccion)
        {
            return conductorModel.guardarConductor(cedula, nombre, apellido, telefono,direccion);

        }














    }
}
