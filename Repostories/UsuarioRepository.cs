using Bibliotec_MVC.Contexts;
using Bibliotec_MVC.Models;
using Bibliotec_MVC.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec_MVC.Repostories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BbDbContext _context;
      
      public UsuarioRepository(BbDbContext context)
        {
            _context = context;
        }
      
        public async Task<Usuario?> BuscarPorEmailSenha(string email, string senha)
        {
            return await _context.Usuario.FirstOrDefaultAsync(u => u.email == email && u.senha == senha);
        }
    }
}