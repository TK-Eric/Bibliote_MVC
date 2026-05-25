using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base.Contexts;
using Base.Interfaces;
using Base.Models;
using Microsoft.EntityFrameworkCore;

namespace Base.Repostories
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
            return await _context.Usuario.FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
        }
    }
}