using Aula3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula3.Controllers
{
    public class PessoaController : Controller
    {
       

        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
           /* if (string.IsNullOrEmpty(pessoa.nome))erro de um elemento do mo é obrigatorio ser preenchido ou não estar vazio
            {
                ModelState.AddModelError("Nome","O campo nome é obrigatorio");
            }
            if (pessoa.Senha != pessoa.ConfimaSenha)aqui é uma falha de modelo então o primeiro elemento é vazio 
            {
                ModelState.AddModelError("", "As senhas não conferem"); tipo 1 de validação
            }tipo 2 é data annotation*/

            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }
        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
            {
                "jeff",
                "mitto",
                "joinha"
            };
            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower()!=login.ToLower()),JsonRequestBehavior.AllowGet);
        }
        
    }
}