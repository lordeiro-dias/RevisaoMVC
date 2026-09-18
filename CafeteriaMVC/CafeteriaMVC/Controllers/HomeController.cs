using System.Diagnostics;
using CafeteriaMVC.Data;
using CafeteriaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeteriaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Criar(string nome, decimal preco, string descricao)
        {
            if (_context.Produtos.Any(p => p.NomeProduto == nome))
            {
                ViewBag.Erro = "Já existe um produto com esse nome";
                return View("Index");
            }

            Produto produto = new Produto
            {
                NomeProduto = nome,
                Preco = preco,
                Descricao = descricao
            };

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
