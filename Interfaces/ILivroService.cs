using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bibliotec.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> BuscarLivrosAsync();
        Task<IEnumerable<Livro>> BuscarLivrosComCatAsync();
    }
}