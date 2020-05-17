using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiAnima.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public long ra { get; set; }
        public string cpf { get; set; }
        [JsonIgnore]
        public Usuario Usuario { get; set; }

    }
}
