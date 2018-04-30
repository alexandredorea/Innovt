using Innovt.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innovt.Infraestrutura.Dados.Configuracao
{
    public class ConfiguracaoMapa : IEntityTypeConfiguration<Mapa>
    {
        /// <summary>
        /// Configuração da tabela de Mapas no Banco de dados
        /// </summary>
        /// <param name="construtor"></param>
        public void Configure(EntityTypeBuilder<Mapa> construtor)
        {
            //Nome da tabela
            construtor.ToTable("Mapas");

            //Definição da chave primaria, índices e nomes dos mesmos
            construtor.HasKey(m => m.MapaId)
                .HasName("PK_Mapas_MapaId")
                .ForSqlServerIsClustered();

            construtor.HasIndex(m => m.MapaId)
                .HasName("IX_Mapas_MapaId")
                .IsUnique();

            //Definição das propriedades no banco de dados
            construtor.Property(m => m.MapaId)
                .UseSqlServerIdentityColumn()
                .ValueGeneratedOnAdd();
            
            construtor.Property(m => m.Latitude)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            construtor.Property(m => m.Longetude)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            //Relacionamentos: N-notícias em 1 determinado local
            construtor.HasMany(m => m.Noticias)
                .WithOne(m => m.Mapa)
                .HasForeignKey(m => m.MapaId)
                .HasConstraintName("FK_Noticias_Mapas_MapaId");
        }
    }
}
