using System.ComponentModel.DataAnnotations;

namespace Bibliotec_MVC.Models
{
    // Modelo que representa uma Categoria de livro no banco de dados
    // Exemplos de categorias: "Ficção Científica", "Romance", "Técnico", etc.
    public class Categoria
    {
        [Key] // Chave primária da tabela
        public int Id { get; set; }

        [Required]
        [StringLength(50)] // Nome da categoria limitado a 50 caracteres
        public string Nome { get; set; } = null!;

        // Propriedade de navegação para a tabela intermediária LivroCategoria
        // Representa o lado "Categoria" do relacionamento N:N entre Livro e Categoria
        // (uma categoria pode estar associada a vários livros)
        // Inicializada como lista vazia para evitar NullReferenceException
        public ICollection<LivroCategoria> LivrosCategorias { get; set; } = new List<LivroCategoria>();
    }
}