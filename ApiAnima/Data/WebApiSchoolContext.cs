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
            optionsBuilder.UseSqlServer("Password=MyP@ssw0rd;Persist Security Info=True; User ID=sa; Initial Catalog=apiSchoolDb; Data Source=localhost");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matricula>(entity => {
                entity.HasKey(e => new { e.AlunoId, e.GradeId });
            });

            
            modelBuilder.Entity<Aluno>()
                    .HasOne(p => p.Usuario)
                    .WithMany(b => b.alunos);
            

        }

        public WebApiSchoolContext()
        {
        }
    }
}
