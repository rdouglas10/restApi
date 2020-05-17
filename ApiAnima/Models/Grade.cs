using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiAnima.Models
{
    public class Grade
    {

        [Key]
        public int codGrade { get; set; }
        public string curso { get; set; }
        public string disciplina { get; set; }
        public string turma { get; set; }
        //public Teacher Teacher { get; set; }
        //public int TeacherId { get; set; }
        public List<Professor> codFuncionario { get; set; }
        public List<Matricula> matriculas { get; set; }

        public Grade()
        {
        }
    }
}
