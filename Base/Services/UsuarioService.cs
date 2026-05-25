using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base.Interfaces;
using Base.Models;

namespace Base.Services
{
    public class UsuarioService : IUsuarioService   
    {
       
       private readonly IUsuarioRepository _usuarioRepository;

       public UsuarioService(IUsuarioRepository usuarioRepository)
       {
        _usuarioRepository = usuarioRepository;
       }
        public async Task<Usuario?> AutenticarUsuario(string email, string senha)
        {
            return await _usuarioRepository.BuscarPorEmailSenha
            (email, senha);
        }
    }
}