using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using dotNET_2019.Models;

namespace dotNET_2019.Dados
{
    public partial class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext()
        {
        }

        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=biblioteca.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            #region SistemaUsuario
            modelBuilder.Entity<SistemaUsuario>()
                .HasKey(bc => new { bc.SistemaID, bc.UsuarioID });

            modelBuilder.Entity<SistemaUsuario>()
                .HasOne(bc => bc.Sistemas)
                .WithMany(b => b.SistUsuarios)
                .HasForeignKey(bc => bc.SistemaID);

            modelBuilder.Entity<SistemaUsuario>()
                .HasOne(bc => bc.Usuarios)
                .WithMany(c => c.SistUsuarios)
                .HasForeignKey(bc => bc.UsuarioID);
            #endregion

            #region LivroAutor

            //// Gera Chave Primaria Composta
            modelBuilder.Entity<LivroAutor>()
                .HasKey(bc => new { bc.AutorID, bc.LivroID });

            modelBuilder.Entity<LivroAutor>()
                .HasOne(bc => bc.Autor)
                .WithMany(b => b.LivAutor)
                .HasForeignKey(bc => bc.AutorID);

            modelBuilder.Entity<LivroAutor>()
                .HasOne(bc => bc.Livro)
                .WithMany(c => c.LivAutor)
                .HasForeignKey(bc => bc.LivroID);

            #endregion

            #region LivroEmprestimo

            modelBuilder.Entity<LivroEmprestimo>()
                .HasKey(bc => new { bc.LivroID, bc.EmprestimoID });

            modelBuilder.Entity<LivroEmprestimo>()
                .HasOne(bc => bc.Livro)
                .WithMany(b => b.LivEmprestimo)
                .HasForeignKey(bc => bc.LivroID);

            modelBuilder.Entity<LivroEmprestimo>()
                .HasOne(bc => bc.Emprestimo)
                .WithMany(c => c.LivEmprestimo)
                .HasForeignKey(bc => bc.EmprestimoID);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<dotNET_2019.Models.Livro> Livro { get; set; }

        // //public DbSet<dotNET_2019.Models.Categoria> Categoria { get; set; }

        public DbSet<dotNET_2019.Models.Autor> Autor { get; set; }

        public DbSet<dotNET_2019.Models.Emprestimo> Emprestimo { get; set; }

        public DbSet<dotNET_2019.Models.Usuario> Usuario { get; set; }

        public DbSet<dotNET_2019.Models.LivroAutor> LivroAutor { get; set; }

        public DbSet<dotNET_2019.Models.LivroEmprestimo> LivroEmprestimo { get; set; }
    }
}
