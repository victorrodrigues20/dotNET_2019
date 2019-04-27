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
        }

        public DbSet<dotNET_2019.Models.Livro> Livro { get; set; }
        public DbSet<dotNET_2019.Models.Autor> Autor { get; set; }
        public DbSet<dotNET_2019.Models.LivroAutor> LivroAutor { get; set; }
    }
}
