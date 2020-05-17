using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAnima.Models
{
    public class Matricula
    {
        public Aluno Aluno { get; set; }
        public int AlunoId { get; set; }
        public Grade Grade { get; set; }
        public int GradeId { get; set; }

        public Matricula()
        {
        }
    }
}
