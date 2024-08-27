using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Matheus", "math2306.r@gmail.com", 1234567);
            Aluno a2 = new Aluno(2, "Alice", "Lice23@gmail.com", 2234567);
            Aluno a3 = new Aluno(3, "Lucas", "Lucas@gmail.com", 3234567);
            Aluno a4 = new Aluno(4, "Julio", "JULIo@gmail.com", 4234567);
            Aluno a5 = new Aluno(5, "Joao", "jaoka@gmail.com", 5234567);
            List<Aluno> Alunos = new List<Aluno>();
            Alunos.Add(a1);
            Alunos.Add(a2);
            Alunos.Add(a3);
            Alunos.Add(a4);
            Alunos.Add(a5);



            return View(Alunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
