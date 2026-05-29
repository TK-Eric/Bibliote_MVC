using bibliotec.Contexts;
using bibliotec.Models;
using bibliotec.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bibliotec.Repostories
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