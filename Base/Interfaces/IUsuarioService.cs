using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base.Models;

namespace Base.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario?> AutenticarUsuario (string email, string senha);
    }
}