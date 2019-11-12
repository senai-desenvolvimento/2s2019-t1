using System;
using System.Collections.Generic;
using McBonaldsMVC.Controllers;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.Utils;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Views.Cadastro
{
    public class CadastroController : BaseController
    {
        
        ClienteRepository repositorio = new ClienteRepository();

        public CadastroController ()
        {
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BaseViewModel());
        }

        [HttpPost]
        public IActionResult CadastrarCliente(IFormCollection form) 
        {
            // EXEMPLO 1 - Criação de objeto
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            if (repositorio.Inserir(cliente))
            {
                return View("Sucesso", new RespostaViewModel($"{cliente.Nome} obrigado por se cadastrar!"));
            }
            else 
            {
                return View("Falha", new RespostaViewModel($"{cliente.Nome} houve um erro ao tentar lhe cadastrar. Por favor, tente novamente mais tarde."));
            }            
        }


    }
}