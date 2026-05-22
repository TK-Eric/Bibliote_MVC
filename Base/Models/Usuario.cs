using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base.Models
{
    public class Usuario
    {
        [Key]
        public int Id {get; set;}

        [Required]
        [StringLength(20)]
        public string Matricula {get; set;}

        public bool Ativo {get; set;}   
        [Required]
        [StringLength(100)]
        public string Nome {get; set;} = null!;

        [Required]
        [StringLength(100)]
        public string Email {get; set;} = null!;

        [Required]
        [StringLength(50)]
        public string Senha {get; set;} = null!;

        [Required]
        [StringLength(50)]
        public string NumCell {get; set;} = null!;

         public bool TipoBib {get; set;}  

        //0 ou falso = aluno, 1 ou true = bibliotcaria

         public ICollection <Reserva> Reservas {get; set;} = new
         List<Reserva>();    

    }
}