using Business.Interfaces;
using CalcularIdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcularIdade.Controllers
{
    public class CalculoController : Controller
    {
        private ICalculo calculo;
        public CalculoController(ICalculo calculo)
        {
            this.calculo = calculo;
        }
        // GET: Calculo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calculo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calculo/Create
        [HttpPost]
        public ActionResult Soma(Pessoa collection)
        {
            try
            {
               
                ViewBag.Idade = "Sua idade é: " + calculo.anos(collection.Data_Nascimento) + " anos, " + calculo.meses(collection.Data_Nascimento) + " meses, e " + calculo.dias(calculo.anos(collection.Data_Nascimento),collection.Data_Nascimento) + " dias";
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
