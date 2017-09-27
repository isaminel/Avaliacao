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
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Tipos
        public ActionResult Index()
        {
            var tpa = _context.TiposAssociacao.ToList();
            return View(tpa);
        }

        public ActionResult Details(int id)
        {
            var tpa = _context.TiposAssociacao.SingleOrDefault(a => a.Id == id);

            if (tpa == null)
                return HttpNotFound();

            return View(tpa);
        }
    }
}