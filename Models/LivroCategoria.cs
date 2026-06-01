using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotec_MVC.Models
{
    public class LivroCategoria
    {
        public int LivroId {get; set;}

        [ForeignKey("LivroId")]

        public Livro Livro {get; set;} = null!;
        public int CategoriaId {get; set;}

        [ForeignKey("CategoriaId")]

        public Categoria Categoria {get; set;} = null!;
    }
}