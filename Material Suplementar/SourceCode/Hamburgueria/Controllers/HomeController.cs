using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hamburgueria.Models;
using Microsoft.AspNetCore.Http;

namespace Hamburgueria.Controllers
{
    public class HomeController : BaseController
    {
        
        private const string SessionEmail = "_EMAIL";
        private const string SessionCliente = "_CLIENTE";
        public IActionResult Index()
        {
            // TODO: Remover todos os ViewData
            ViewData["NomeView"] = "Home";
            // ViewData["User"] = HttpContext.Session.GetString(SessionEmail);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
