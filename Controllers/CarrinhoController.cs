using dotNET_2019.Dados;
using dotNET_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace dotNET_2019.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly BibliotecaDbContext _context;

        public CarrinhoController(BibliotecaDbContext context)
        {
            _context = context;
        }

        // GET: Carrinho
        public ActionResult Index()
        {
            if (GetCarrinho() == null)
                SetCarrinho(new List<Livro>());

            return View(GetCarrinho());
        }

        // GET: Carrinho
        public ActionResult Adicionar(int? id)
        {
            List<Livro> listaLivros = GetCarrinho();

            var livro = _context.Livro.FirstOrDefault(x => x.LivroID == id);

            listaLivros.Add(livro);
            SetCarrinho(listaLivros);

            return View("Index", GetCarrinho());
        }

        private List<Livro> GetCarrinho()
        {
            string carrinhoStr = HttpContext.Session.GetString("Carrinho");

            if (carrinhoStr == null)
                return new List<Livro>();

            return JsonConvert.DeserializeObject<List<Livro>>(carrinhoStr);
        }

        private void SetCarrinho(List<Livro> carrinho)
        {
            string carrinhoStr = JsonConvert.SerializeObject(carrinho);
            HttpContext.Session.SetString("Carrinho", carrinhoStr);
        }
    }
}
