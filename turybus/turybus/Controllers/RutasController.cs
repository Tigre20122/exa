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
    public class RutasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private RutaModel rutaModel;

        public RutasController(ApplicationDbContext context)
        {
            _context = context;
            rutaModel = new RutaModel(_context); 
        }

        [Authorize(Roles = "Administrador")]

        public async Task<IActionResult> Index()
        {
            return View(await _context.Rutas.ToListAsync());
        }

        public async Task<List<Ruta>> MostrarAjax(int id)
        {
            List<Ruta> rut = new List<Ruta>();
            var appPro = await _context.Rutas.SingleOrDefaultAsync(r => r.IdRuta == id);
            rut.Add(appPro);
            return rut;
        }

        public async Task<String> EliminarAjax(int id)
        {
            var rut = await _context.Rutas.SingleOrDefaultAsync(r => r.IdRuta == id);
            _context.Rutas.Remove(rut);
            await _context.SaveChangesAsync();
            return "delete";
        }
        public List<IdentityError> guardarRuta(string nombre,string descripcion,string estado)
        {
           return rutaModel.guardarRuta(nombre,descripcion,estado); 

        }

        public List<object[]> Lista_Ruta_Controller()
        {
            return rutaModel.Lista_Ruta_Model();
        }


    }
}
