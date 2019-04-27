using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotNET_2019.Dados;
using dotNET_2019.Models;
using dotNET_2019.Utils;

namespace dotNET_2019.Controllers
{
    public class LivrosController : Controller
    {
        private readonly BibliotecaDbContext _context;

        public LivrosController(BibliotecaDbContext context)
        {
            _context = context;
        }

        // GET: Livros
        // GET: Livros
        // GET: Livros
        public async Task<IActionResult> Index(string filtroPesquisa, string ordenacao)
        {
            ViewBag.TituloSortParam = String.IsNullOrEmpty(ordenacao) ? "titulo_desc" : "";

            ViewBag.filtroPesquisa = filtroPesquisa;

            var livros = from l in _context.Livro
                         select l;

            if (!String.IsNullOrEmpty(filtroPesquisa))
            {
                livros = livros.Where(s => s.Titulo.ToUpper().Contains(filtroPesquisa.ToUpper()));
            }

            switch (ordenacao)
            {
                case "titulo_desc":
                    livros = livros.OrderByDescending(s => s.Titulo);
                    break;
                default:
                    livros = livros.OrderBy(s => s.Titulo);
                    break;
            }

            return View(await livros.ToListAsync());
        }



        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var livro = await _context.Livro
            //     .FirstOrDefaultAsync(m => m.LivroID == id);

            var livro = await _context.Livro.AsNoTracking()
                    .Include(l => l.LivAutor)
                    .ThenInclude(li => li.Autor)
                    .SingleOrDefaultAsync(m => m.LivroID == id);

            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            ViewBag.Autores = new Listagens(_context).AutoresCheckBox();
            return View(new Livro());
        }

        // POST: Livros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LivroID,Foto,Quantidade,Titulo,AutorUnico")] Livro livro, string[] selectedAutores)
        {
            if (ModelState.IsValid)
            {
                if (selectedAutores != null)
                {
                    livro.LivAutor = new List<LivroAutor>();

                    foreach (var idAutor in selectedAutores)
                        livro.LivAutor.Add(new LivroAutor() { AutorID = int.Parse(idAutor), Livro = livro });
                }

                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(livro);
        }


        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoresAux = new Listagens(_context).AutoresCheckBox();

            var livro = await _context.Livro.Include(l => l.LivAutor)
                .SingleOrDefaultAsync(m => m.LivroID == id);

            autoresAux.ForEach(a => a.Checked = livro.LivAutor.Any(l => l.AutorID == a.Value));

            ViewBag.Autores = autoresAux;

            // var livro = await _context.Livro.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LivroID,Titulo,Quantidade")] Livro livro, string[] selectedAutores)
        {
            if (id != livro.LivroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var livroAutores = _context.LivroAutor.AsNoTracking().Where(la => la.LivroID == livro.LivroID);

                    _context.LivroAutor.RemoveRange(livroAutores);
                    await _context.SaveChangesAsync();

                    if (selectedAutores != null)
                    {
                        livro.LivAutor = new List<LivroAutor>();

                        foreach (var idAutor in selectedAutores)
                            livro.LivAutor.Add(new LivroAutor() { AutorID = int.Parse(idAutor), Livro = livro });
                    }

                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.LivroID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.LivroID == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livro.FindAsync(id);
            _context.Livro.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livro.Any(e => e.LivroID == id);
        }
    }
}
