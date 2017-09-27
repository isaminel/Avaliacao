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
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            var aluno = _context.Alunos.Include(c => c.Faixa).Include(c => c.TipoDeAssociacao).ToList();
            return View(aluno);
        }

        public ActionResult Details(int id)
        {
            var aluno = _context.Alunos.Include(c => c.Faixa).Include(c => c.TipoDeAssociacao).SingleOrDefault(m => m.Id == id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }
    }
}