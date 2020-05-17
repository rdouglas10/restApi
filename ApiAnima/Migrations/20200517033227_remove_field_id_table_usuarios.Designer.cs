﻿// <auto-generated />
using System;
using ApiAnima.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiAnima.Migrations
{
    [DbContext(typeof(WebApiSchoolContext))]
    [Migration("20200517033227_remove_field_id_table_usuarios")]
    partial class remove_field_id_table_usuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiAnima.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Usuariocpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("ra")
                        .HasColumnType("bigint");

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Usuariocpf");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("ApiAnima.Models.Grade", b =>
                {
                    b.Property<int>("codGrade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("disciplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codGrade");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("ApiAnima.Models.Matricula", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("ApiAnima.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GradecodGrade")
                        .HasColumnType("int");

                    b.Property<string>("Usuariocpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("GradecodGrade");

                    b.HasIndex("Usuariocpf");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("ApiAnima.Models.Usuario", b =>
                {
                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cpf");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ApiAnima.Models.Aluno", b =>
                {
                    b.HasOne("ApiAnima.Models.Usuario", "Usuario")
                        .WithMany("alunos")
                        .HasForeignKey("Usuariocpf")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiAnima.Models.Matricula", b =>
                {
                    b.HasOne("ApiAnima.Models.Aluno", "Aluno")
                        .WithMany("matriculas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAnima.Models.Grade", "Grade")
                        .WithMany("matriculas")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiAnima.Models.Professor", b =>
                {
                    b.HasOne("ApiAnima.Models.Grade", null)
                        .WithMany("codFuncionario")
                        .HasForeignKey("GradecodGrade");

                    b.HasOne("ApiAnima.Models.Usuario", "Usuario")
                        .WithMany("professores")
                        .HasForeignKey("Usuariocpf")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
