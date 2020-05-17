using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAnima.Models
{
    public class Usuario
    {

        //public int Id { get; set; }
        [Key]
        public string cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }        
        public string login { get; set; }
        public string senha { get; set; }
        public Aluno Aluno { get; set; }
        //public virtual Aluno Aluno { get; set; }
        //public List<Professor> professores { get; set; }

    }
}
