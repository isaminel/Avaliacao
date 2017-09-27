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

        // GET: Customers
        public ActionResult Index()
        {
            var aluno = _context.Alunos.ToList();
            return View(aluno);
        }

        public ActionResult Details(int id)
        {
            var aluno = _context.Alunos.SingleOrDefault(c => c.Id == id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }
    }
}