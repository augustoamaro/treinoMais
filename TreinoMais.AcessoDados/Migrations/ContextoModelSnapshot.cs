﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreinoMais.AcessoDados;

namespace TreinoMais.AcessoDados.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TreinoMais.Dominio.Models.Administrador", b =>
                {
                    b.Property<int>("AdministradorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("AdministradorId");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FrequenciaSemanal");

                    b.Property<int>("Idade");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("ObjetivoId");

                    b.Property<int>("Peso");

                    b.Property<int>("ProfessorId");

                    b.HasKey("AlunoId");

                    b.HasIndex("ObjetivoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.CategoriaExercicio", b =>
                {
                    b.Property<int>("CategoriaExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategoriaExercicioId");

                    b.ToTable("CategoriasExercicios");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaExercicioId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ExercicioId");

                    b.HasIndex("CategoriaExercicioId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.ListaExercicio", b =>
                {
                    b.Property<int>("ListaExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Carga");

                    b.Property<int>("ExercicioId");

                    b.Property<int>("Frequencia");

                    b.Property<int>("Repeticoes");

                    b.Property<int>("TreinoId");

                    b.HasKey("ListaExercicioId");

                    b.HasIndex("ExercicioId");

                    b.HasIndex("TreinoId");

                    b.ToTable("ListasExercicios");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Objetivo", b =>
                {
                    b.Property<int>("ObjetivoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ObjetivoId");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministradorId");

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("ProfessorId");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Treino", b =>
                {
                    b.Property<int>("TreinoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId");

                    b.Property<DateTime>("Cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Validade");

                    b.HasKey("TreinoId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Aluno", b =>
                {
                    b.HasOne("TreinoMais.Dominio.Models.Objetivo", "Objetivo")
                        .WithMany("Alunos")
                        .HasForeignKey("ObjetivoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TreinoMais.Dominio.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Exercicio", b =>
                {
                    b.HasOne("TreinoMais.Dominio.Models.CategoriaExercicio", "CategoriaExercicio")
                        .WithMany("Exercicios")
                        .HasForeignKey("CategoriaExercicioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.ListaExercicio", b =>
                {
                    b.HasOne("TreinoMais.Dominio.Models.Exercicio", "Exercicio")
                        .WithMany("ListaExercicios")
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TreinoMais.Dominio.Models.Treino", "Treino")
                        .WithMany("ListaExercicios")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Professor", b =>
                {
                    b.HasOne("TreinoMais.Dominio.Models.Administrador", "Administrador")
                        .WithMany("Professores")
                        .HasForeignKey("AdministradorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TreinoMais.Dominio.Models.Treino", b =>
                {
                    b.HasOne("TreinoMais.Dominio.Models.Aluno", "Aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
