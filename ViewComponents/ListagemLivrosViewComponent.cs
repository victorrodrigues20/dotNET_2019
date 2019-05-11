using dotNET_2019.Dados;
using dotNET_2019.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNET_2019.ViewComponents
{
    public class ListagemLivrosViewComponent : ViewComponent
    {
        private readonly BibliotecaDbContext _context;

        public ListagemLivrosViewComponent(BibliotecaDbContext c)
        {
            _context = c;
        }

        public async Task<IViewComponentResult> InvokeAsync(int autorID)
        {
            var produtos = await GetListagemLivrosAsync(autorID);
            return View(produtos);
        }

        private Task<IEnumerable<Livro>> GetListagemLivrosAsync(int autorID)
        {
            var livros = _context.Livro.AsNoTracking()
                        .Include(l => l.LivAutor)
                        .ThenInclude(li => li.Autor)
                        .OrderBy(l => l.Titulo);

            if (autorID != 0)
                livros.Where(x => x.LivAutor.Any(y => y.AutorID == autorID));

            return Task.FromResult(livros.AsEnumerable());
        }
    }
}
