
using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> BuscarLivrosAsync();
        Task<IEnumerable<Categoria>> ListarCategoriasAsync();

        Task CadastrarLivro(Livro l);

        Task CadastrarCatLivroAsync(LivroCategoria lc);

        Task DeletarLivroAsync(Livro l);

        Task DeletarCatLivroAsync(LivroCategoria l);

        Task <Livro?> BuscarLivrosIdAsync(int Id);
        Task DeletarCatLivroAsync(int id);
    }
}