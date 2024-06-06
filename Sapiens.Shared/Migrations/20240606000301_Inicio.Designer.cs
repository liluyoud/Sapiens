﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sapiens.Shared.Contexts;

#nullable disable

namespace Sapiens.Shared.Migrations
{
    [DbContext(typeof(SapiensContext))]
    [Migration("20240606000301_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Sapiens.Shared.Entities.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CorOuRaca")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstadoCivil")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Facebook")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Instagram")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkedIn")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("PCD")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Sexo")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Situacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TikTok")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("TipoSanguinio")
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Twitter")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CoordenadorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CoordenadorId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Semestre")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CorOuRaca")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ECoordenador")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstadoCivil")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Facebook")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Formacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instagram")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkedIn")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("PCD")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Sexo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TikTok")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("TipoSanguinio")
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Titulacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Twitter")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Curso", b =>
                {
                    b.HasOne("Sapiens.Shared.Entities.Professor", "Coordenador")
                        .WithMany()
                        .HasForeignKey("CoordenadorId");

                    b.Navigation("Coordenador");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Disciplina", b =>
                {
                    b.HasOne("Sapiens.Shared.Entities.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId");

                    b.HasOne("Sapiens.Shared.Entities.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId");

                    b.Navigation("Curso");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Matricula", b =>
                {
                    b.HasOne("Sapiens.Shared.Entities.Aluno", "Aluno")
                        .WithMany("Matriculas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sapiens.Shared.Entities.Disciplina", "Disciplina")
                        .WithMany("Matriculas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Aluno", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Curso", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Disciplina", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("Sapiens.Shared.Entities.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
