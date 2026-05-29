using bibliotec.Models;

namespace bibliotec.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario?> AutenticarUsuario (string email, string senha);
    }
}