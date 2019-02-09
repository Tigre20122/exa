using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace turybus.Controllers
{
    public class ReportesController : Controller
    {
        [Authorize(Roles = "Administrador")]

        public IActionResult Index()
        {
            return View();
        }
    }
}