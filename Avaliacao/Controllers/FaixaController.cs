/* by Isabelle isabelle.minel@catolicasc.org.br */

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avaliacao.Models;

namespace Avaliacao.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;

        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Faixa
        public ActionResult Index()
        {
            var faixa = _context.Faixas.ToList();
            return View(faixa);
        }

        public ActionResult Details(int id)
        {
            var faixa = _context.Faixas.SingleOrDefault(a => a.Id == id);

            if (faixa == null)
                return HttpNotFound();

            return View(faixa);
        }
    }
}