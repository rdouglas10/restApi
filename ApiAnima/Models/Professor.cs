using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAnima.Models
{
    public class Professor
    {
        [Key]
        public int id { get; set; }
        public string codigo { get; set; }
        public int usuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public Professor()
        {
        }
    }
}
