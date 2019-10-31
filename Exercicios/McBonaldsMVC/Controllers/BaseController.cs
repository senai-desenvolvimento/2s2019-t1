using System;
using System.Net;
using McBonaldsMVC.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class BaseController : Controller
    {
        protected const string SESSION_EMAIL = "_EMAIL";
        protected const string SESSION_CLIENTE = "_CLIENTE";
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string NomeView { get; set; }

        public BaseController()
        {
            try
            {

                this.UserName = HttpContext.Session.GetString(SESSION_CLIENTE);
                this.UserEmail = HttpContext.Session.GetString(SESSION_EMAIL);
            }
            catch (Exception e)
            {
                this.UserName = "";
                this.UserEmail = "";
            }
        }
    }
}