using System;
using System.Collections.Generic;
using System.Linq;
using ApiAnima.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAnima.Data
{
    public class WebApiSchoolContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Persist Security Info=True; Integrated Security=SSPI; Initial Catalog=apiSchoolDb; Data Source=localhost");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matricula>(entity => {
                entity.HasKey(e => new { e.AlunoId, e.GradeId });
            });


            modelBuilder.Entity<Usuario>()
                    .HasOne(u => u.Aluno)
                    .WithOne(a => a.Usuario)
                    .HasForeignKey<Aluno>(a => a.cpf);
        }

        public WebApiSchoolContext()
        {
        }
    }
}
