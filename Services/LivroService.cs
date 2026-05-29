using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bibliotec.Models;

namespace Bibliotec_MVC.Interfaces
{
    public class LivroService : ILivroService
    {

        private readonly ILivroRepository _livroRepository;
        
        public LivroService(ILivroRepository livroRepository)

        {
            _livroRepository = livroRepository;
        }

        public Task<IEnumerable<Livro>> BuscarLivrosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Livro>> BuscarLivrosComCatAsync()
        {
            return await _livroRepository.BuscarLivrosAsync();
        }
    }

    
}