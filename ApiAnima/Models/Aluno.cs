using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAnima.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public long ra { get; set; }
        public int usuarioId { get; set; }        
        public Usuario Usuario { get; set; }
        //public List<Matricula> matriculas { get; set; }

        public Aluno()
        {
        }
    }
}
