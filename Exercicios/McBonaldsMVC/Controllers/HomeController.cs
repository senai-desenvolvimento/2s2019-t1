using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Models;
using Microsoft.AspNetCore.Http;
using McBonaldsMVC.ViewModels;

namespace McBonaldsMVC.Controllers
{
    public class HomeController : BaseController
    {
        
        public IActionResult Index()
        {
            return View(new BaseViewModel(){
                NomeView = "Home",
                UsuarioNome = HttpContext.Session.GetString(SESSION_CLIENTE),
                UsuarioEmail = HttpContext.Session.GetString(SESSION_EMAIL)
            });
        }

    }
}
