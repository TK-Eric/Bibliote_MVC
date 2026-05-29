using bibliotec.Models;

namespace bibliotec.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> BuscarPorEmailSenha(string email, string senha);
    }
}