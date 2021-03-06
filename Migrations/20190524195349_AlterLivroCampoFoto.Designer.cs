﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotNET_2019.Dados;

namespace dotNET_2019.Migrations
{
    [DbContext(typeof(BibliotecaDbContext))]
    [Migration("20190524195349_AlterLivroCampoFoto")]
    partial class AlterLivroCampoFoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("dotNET_2019.Models.Autor", b =>
                {
                    b.Property<int>("AutorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("AutorID");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("dotNET_2019.Models.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataDevolucao");

                    b.Property<string>("DataFim");

                    b.Property<string>("DataInicio");

                    b.Property<int>("UsuarioID");

                    b.HasKey("EmprestimoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("dotNET_2019.Models.Livro", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Foto");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("LivroID");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("dotNET_2019.Models.LivroAutor", b =>
                {
                    b.Property<int>("AutorID");

                    b.Property<int>("LivroID");

                    b.HasKey("AutorID", "LivroID");

                    b.HasIndex("LivroID");

                    b.ToTable("LivroAutor");
                });

            modelBuilder.Entity("dotNET_2019.Models.LivroEmprestimo", b =>
                {
                    b.Property<int>("LivroID");

                    b.Property<int>("EmprestimoID");

                    b.HasKey("LivroID", "EmprestimoID");

                    b.HasIndex("EmprestimoID");

                    b.ToTable("LivroEmprestimo");
                });

            modelBuilder.Entity("dotNET_2019.Models.Sistema", b =>
                {
                    b.Property<int>("SistemaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("SistemaID");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("dotNET_2019.Models.SistemaUsuario", b =>
                {
                    b.Property<int>("SistemaID");

                    b.Property<int>("UsuarioID");

                    b.HasKey("SistemaID", "UsuarioID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("SistemaUsuario");
                });

            modelBuilder.Entity("dotNET_2019.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int?>("CategoriaID");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("dotNET_2019.Models.Emprestimo", b =>
                {
                    b.HasOne("dotNET_2019.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotNET_2019.Models.LivroAutor", b =>
                {
                    b.HasOne("dotNET_2019.Models.Autor", "Autor")
                        .WithMany("LivAutor")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotNET_2019.Models.Livro", "Livro")
                        .WithMany("LivAutor")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotNET_2019.Models.LivroEmprestimo", b =>
                {
                    b.HasOne("dotNET_2019.Models.Emprestimo", "Emprestimo")
                        .WithMany("LivEmprestimo")
                        .HasForeignKey("EmprestimoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotNET_2019.Models.Livro", "Livro")
                        .WithMany("LivEmprestimo")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotNET_2019.Models.SistemaUsuario", b =>
                {
                    b.HasOne("dotNET_2019.Models.Sistema", "Sistemas")
                        .WithMany("SistUsuarios")
                        .HasForeignKey("SistemaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotNET_2019.Models.Usuario", "Usuarios")
                        .WithMany("SistUsuarios")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
