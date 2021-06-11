using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Produtos.Models;
using System.Collections.ObjectModel;

namespace Produtos.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            var produto = new Produto();
            return View(produto);
        }
        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            if(ModelState.IsValid)
            {
                return View("Resultado", produto);
            }
            return View(produto);
        }

        public ActionResult Resultado(Produto produto)
        {
            return View(produto);
        }
    }
}