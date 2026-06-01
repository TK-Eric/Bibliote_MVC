using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario?> AutenticarUsuario (string email, string senha);
    }
}