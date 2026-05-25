using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using bibliotec.Models;

namespace Base.Models
{
    public class LivroCategoria
    {
        public int LivroId {get; set;}

        [ForeignKey("Livro")]

        public Livro Livro {get; set;} = null!;
        public int CategoriaId {get; set;}

        [ForeignKey("Categoria")]

        public Categoria Categoria {get; set;} = null!;
    }
}