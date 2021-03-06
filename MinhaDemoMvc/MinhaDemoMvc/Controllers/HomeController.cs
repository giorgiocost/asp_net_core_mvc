﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index()
        {
            var filme = new Filme
            {
                Titulo = "Oi",
                Valor = 12,
                Avaliacao = 10,
                Genero = null,
                DataLancamento = DateTime.Now
            };

            //return RedirectToAction("Privacy", filme);
            return View();
        }
       
        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(
            //string id, Guid categoria, string queryString
            Filme filme
        )
        {
            if(ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            return View();

            //return Json("{ 'nome': 'giorgio' }");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
