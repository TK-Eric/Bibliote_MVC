using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> BuscarPorEmailSenha(string email, string senha);
    }
}