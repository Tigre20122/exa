using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace turybus.Controllers
{
    public class Reporte2Controller : Controller
    {
        [Authorize(Roles = "Administrador")]

        public IActionResult Index()
        {
            return View();
        }
    }
}