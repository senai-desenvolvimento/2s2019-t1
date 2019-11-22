using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {

        ClienteRepository clienteRepositorio = new ClienteRepository();
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try {
                Cliente cliente = new Cliente(
                    form["nome"], 
                    form["endereco"], 
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    DateTime.Parse(form["data-nascimento"])
                );
                    
                clienteRepositorio.Inserir(cliente);
                
                return View("Sucesso");
            } 
            catch(Exception e)
            {
                return View("Erro");
            }
        }
    }
}