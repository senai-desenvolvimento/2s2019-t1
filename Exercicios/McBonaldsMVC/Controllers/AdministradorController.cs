using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AdministradorController : BaseController
    {
        public AdministradorController()
        {
            this.NomeView = "Cliente";
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            ViewData["NomeView"] = "Dashboard";
            return View();
        }
    }
}