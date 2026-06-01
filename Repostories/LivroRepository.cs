
using Bibliotec_MVC.Contexts;
using Bibliotec_MVC.Models;
using Bibliotec_MVC.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec_MVC.Repostories
{
    public class LivroRepository : ILivroRepository
    {

        private readonly BbDbContext _context;

        public LivroRepository(BbDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> BuscarLivrosAsync()
        {
            return await _context.Livro
            .Include(l => l.LivroCategorias)
            .ThenInclude(lc => lc.Categoria)
            .ToListAsync();
        }

        public async Task<Livro?> BuscarLivrosIdAsync(int Id)
        {
            return await _context.Livro.FindAsync(Id);
        }

        public async Task CadastrarCatLivroAsync(LivroCategoria lc)
        {
            await _context.LivroCategoria.AddAsync(lc);
            await _context.SaveChangesAsync();

        }

        public async Task CadastrarLivro(Livro l)
        {
            await _context.Livro.AddAsync(l);
            await _context.SaveChangesAsync();

        }

        public async Task DeletarCatLivroAsync(IEnumerable<LivroCategoria> lcs)
        {
            _context.LivroCategoria.RemoveRange(lcs);
            await _context.SaveChangesAsync();
        }

        public Task DeletarCatLivroAsync(LivroCategoria l)
        {
            throw new NotImplementedException();
        }

        public Task DeletarCatLivroAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeletarLivroAsync(Livro l)
        {
            _context.Livro.Remove(l);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Categoria>> ListarCategoriasAsync()
        {
            return await _context.Categoria.ToListAsync();
        }



    }
}