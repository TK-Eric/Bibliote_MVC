using System.ComponentModel.DataAnnotations;
using Base.Models; // Importa os atributos de validação do .NET (Key, Required, StringLength)

namespace bibliotec.Models
{
    // Modelo que representa um Livro no banco de dados (mapeado como tabela pelo EF Core)
    public class Livro
    {
        [Key] // Define que este campo é a chave primária da tabela
        public int Id { get; set;}

        [Required]                // Campo obrigatório (não pode ser nulo no banco)
        [StringLength(150)]       // Limita o campo a 150 caracteres no banco
        public string Titulo { get; set; } = null!; // null! avisa ao compilador que será preenchido antes do uso

        [Required]
        [StringLength(100)]
        public string Autor { get; set; } = null!;

        public int AnoPublicacao { get; set; } // Campo opcional (sem [Required]), aceita valor padrão 0

        [Required]
        [StringLength(1)]         // Armazena apenas 1 caractere: D, E ou I
        public string Status { get; set; } = null!;
        // D = disponível; E = emprestado; I = indisponível

        public string? Sinopse { get; set; } // O "?" indica que este campo é nullable (pode ser nulo)

        [Required]
        [StringLength(50)]
        public string Editora { get; set; } = null!;

        public string? Imagem; // Campo nullable para armazenar caminho/URL da capa do livro
                               // ⚠️ Atenção: está declarado como field, não como property (sem get/set)
                               //    Isso pode causar problemas com o EF Core — considere adicionar { get; set; }

        // Propriedade de navegação: um Livro pode ter várias Reservas (relacionamento 1:N)
        // Inicializada como lista vazia para evitar NullReferenceException
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>(); 

        // Propriedade de navegação para tabela intermediária: representa o relacionamento N:N
        // entre Livro e Categoria (um livro pode ter várias categorias e vice-versa)
        public ICollection<LivroCategoria> LivroCategorias { get; set; } = new List<LivroCategoria>();
    }
}