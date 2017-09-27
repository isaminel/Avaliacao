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

        // GET: Customers
        public ActionResult Index()
        {
            var tipoAssociacao = _context.TiposAssociacao.ToList();
            return View(tipoAssociacao);
        }

        public ActionResult Details(int id)
        {
            var tipoAssociacao = _context.TiposAssociacao.SingleOrDefault(c => c.Id == id);

            if (tipoAssociacao == null)
                return HttpNotFound();

            return View(tipoAssociacao);
        }
    }
}