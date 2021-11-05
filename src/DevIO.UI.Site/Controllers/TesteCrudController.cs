using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        public MeuDbContext _context;

        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Rioner Batista",
                Email = "batista.rioner@gmail.com",
                DataNascimento = DateTime.Now
            };

            _context.Add(aluno);
            _context.SaveChanges();

            var aluno2 = _context.Alunos.Find(aluno.Id);
            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "batista.rioner@gmail.com");
            var aluno4 = _context.Alunos.Where(a=> a.Nome == aluno.Nome);

            aluno.Nome = "Roney";
            _context.Update(aluno);
            _context.SaveChanges();

            _context.Remove(aluno);
            _context.SaveChanges();

            return View();
        }

    }
}
