using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bibliotec.Contexts;
using bibliotec.Models;
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
        
    }
}