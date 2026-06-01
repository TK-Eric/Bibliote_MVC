
using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> BuscarLivrosComCatAsync();
        Task<IEnumerable<Categoria>> ListarCategoriasAsync();

        Task CadastrarLivroAsync(Livro l, string? catSelecionadas, IFormFile arquivoImagem, string? ativo);

        Task <bool> RemoverLivroAsync(int Id);
    }
}