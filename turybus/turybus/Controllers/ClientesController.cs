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
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ClienteModel clienteModel;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
            clienteModel = new ClienteModel(_context);

        }
        [Authorize(Roles = "Administrador,Empleado")]

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        public async Task<List<Cliente>> MostrarAjax(int id)
        {
            List<Cliente> clin = new List<Cliente>();
            var appPro = await _context.Clientes.SingleOrDefaultAsync(cl => cl.IdCliente == id);
            clin.Add(appPro);
            return clin;
        }
        

        public List<IdentityError> guardarCliente(string cedula,string nombre, string apellido, string telefono)
        {
            return clienteModel.guardarCliente(cedula,nombre, apellido, telefono);

        }

        public async Task<String> EliminarAjax(int id)
        {
            var rut = await _context.Clientes.SingleOrDefaultAsync(cl => cl.IdCliente == id);
            _context.Clientes.Remove(rut);
            await _context.SaveChangesAsync();
            return "delete";
        }
        public List<object[]> Lista_Cliente_Controller()
        {
            return clienteModel.Lista_Cliente_Model();
        }
    }
}
