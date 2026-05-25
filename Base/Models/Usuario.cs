using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;       // ⚠️ Não está sendo usado nesse arquivo — pode remover
using System.Threading.Tasks;
using bibliotec.Models; // ⚠️ Não está sendo usado nesse arquivo — pode remover

namespace Base.Models
{
    // Modelo que representa um Usuário do sistema (pode ser Aluno ou Bibliotecária)
    public class Usuario
    {
        [Key] // Chave primária da tabela
        public int Id {get; set;}

        [Required]
        [StringLength(20)]       // Matrícula institucional do usuário, limitada a 20 caracteres
        public string Matricula {get; set;} = null!;
        // ⚠️ Falta o "= null!" aqui — o compilador pode emitir aviso de nullable
        // Considere adicionar: public string Matricula { get; set; } = null!;

        public bool Ativo {get; set;} // Indica se o usuário está ativo no sistema
                                      // false = conta desativada; true = conta ativa

        [Required]
        [StringLength(100)]
        public string Nome {get; set;} = null!;

        [Required]
        [StringLength(100)]
        public string Email {get; set;} = null!;

        [Required]
        [StringLength(50)]
        public string Senha {get; set;} = null!;
        // ⚠️ Armazenar senha como string pura é inseguro
        //    Considere salvar apenas o hash da senha (ex: BCrypt) em produção

        [Required]
        [StringLength(50)]
        public string NumCell {get; set;} = null!; // Número de celular para contato

        public bool TipoBib {get; set;}
        // Define o tipo/perfil do usuário:
        // false (0) = Aluno        → pode fazer reservas
        // true  (1) = Bibliotecária → tem acesso administrativo

        // Propriedade de navegação: um Usuário pode ter várias Reservas (relacionamento 1:N)
        // Inicializada como lista vazia para evitar NullReferenceException
        public ICollection<Reserva> Reservas {get; set;} = new List<Reserva>();
    }
}