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
            this.NomeView = "Cadastro";
        }

        public IActionResult Index()
        {
            return View(new BaseViewModel(this));
        }

        public IActionResult Cadastrar(IFormCollection form) 
        {
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            repositorio.Inserir(cliente);
            
            ViewData["H2"] = "Cadastro";
            return View("Sucesso", new BaseViewModel(this));
        }


    }
}