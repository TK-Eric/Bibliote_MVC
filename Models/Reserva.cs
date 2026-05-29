using System.ComponentModel.DataAnnotations;           // Atributos de validação (Key, Required, StringLength)
using System.ComponentModel.DataAnnotations.Schema;    // Atributos de mapeamento do banco (ForeignKey, Column, etc.)

namespace bibliotec.Models
{
    // Modelo que representa uma Reserva/Empréstimo de livro no banco de dados
    public class Reserva
    {
        [Key] // Chave primária da tabela
        public int Id { get; set; }

        public DateTime DataReserva { get; set; } // Data em que a reserva foi criada

        public DateTime? DataEmprestimo { get; set; } // Data em que o livro foi fisicamente entregue ao aluno
                                                      // Nullable: só é preenchida quando o empréstimo de fato ocorre

        public DateTime? DataPrevistaDevolucao { get; set; } // Prazo esperado para devolução
                                                              // Nullable: definida junto com o empréstimo

        public string? DanoLivro { get; set; } // Descrição de danos encontrados no livro na devolução
                                               // Nullable: será nulo se o livro voltar sem danos

        [Required]
        [StringLength(1)]         // Armazena apenas 1 caractere: E, P, A ou F
        public string Status { get; set; } = null!;
        // E = espera (reservado, aguardando retirada)
        // P = posse (livro em mãos do aluno)
        // A = atrasado (prazo de devolução expirado)
        // F = finalizada (livro devolvido)

        // --- Relacionamento com Usuario (Aluno) ---

        public int AlunoId { get; set; } // Chave estrangeira: guarda o Id do aluno no banco

        [ForeignKey("AlunoId")] // Informa ao EF Core que "Aluno" é a propriedade de navegação de "AlunoId"
        public Usuario Aluno { get; set; } = null!; // Propriedade de navegação: permite acessar os dados
                                                    // completos do aluno via Reserva.Aluno.Nome, etc.

        // --- Relacionamento com Livro ---

        public int LivroId { get ; set; } // Chave estrangeira: guarda o Id do livro no banco

        [ForeignKey("LivroId")] // Informa ao EF Core que "Livro" é a propriedade de navegação de "LivroId"
        public Livro Livro { get; set; } = null!; // Propriedade de navegação: permite acessar os dados
                                                  // completos do livro via Reserva.Livro.Titulo, etc.
    }
}