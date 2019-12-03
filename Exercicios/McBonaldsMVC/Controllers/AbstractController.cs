using System;
using System.Net;
using McBonaldsMVC.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public abstract class AbstractController : Controller
    {
        protected const string SESSION_EMAIL = "_EMAIL";
        protected const string SESSION_CLIENTE = "_CLIENTE";

        protected const string PATH_FOTOS = "images\\fotos";

        public AbstractController()
        {

        }

        protected string RecuperarUsuarioNomeDaSessao()
        {
            var usuario = HttpContext.Session.GetString(SESSION_CLIENTE);
            if (!string.IsNullOrEmpty(usuario)) {
                return usuario;
            }
            else 
            {
                return "";
            }
        }

        protected string RecuperarUsuarioEmailDaSessao()
        {
            var email = HttpContext.Session.GetString(SESSION_EMAIL);

            if (!string.IsNullOrEmpty(email)) {
                return email;
            }
            else 
            {
                return "";
            }
        }
    }
}