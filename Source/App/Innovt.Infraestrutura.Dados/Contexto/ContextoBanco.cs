using Innovt.Dominio.Entidades;
using Innovt.Infraestrutura.Dados.Configuracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;

namespace Innovt.Infraestrutura.Dados.Contexto
{
    public class ContextoBanco : DbContext
    {
        ///// <summary>
        ///// Construto de conexão com banco de dados
        ///// </summary>
        ///// <param name="conexao">ConnectionString</param>
        //public ContextoBanco(DbContextOptions<ContextoBanco> conexao) : base(conexao)
        //{
        //}

        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Mapa> Mapas { get; set; }

        /// <summary>
        /// Configuração do banco de dados.
        /// </summary>
        /// <param name="optionsBuilder">Construtor de opções</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=Innovt;Trusted_Connection=True;");
        }

        /// <summary>
        /// Criação do banco de dados
        /// </summary>
        /// <param name="modelBuilder">Modelo de informações do banco</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfiguracaoNoticia());
            modelBuilder.ApplyConfiguration(new ConfiguracaoMapa());
        }

        /// <summary>
        /// Sobrescrita do método SaveChanges
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (EntityEntry entrada in ChangeTracker.Entries().Where(dado => dado.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                switch (entrada.State)
                {
                    case EntityState.Modified:
                        entrada.Property("DataCadastro").IsModified = false;
                        break;
                    case EntityState.Added:
                        entrada.Property("DataCadastro").CurrentValue = DateTime.Now;
                        break;
                }
            }
            return base.SaveChanges();
        }
    }
}