using Innovt.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innovt.Infraestrutura.Dados.Configuracao
{
    public class ConfiguracaoNoticia : IEntityTypeConfiguration<Noticia>
    {
        /// <summary>
        /// Configuração da tabela de Notícias do Banco de Dados
        /// </summary>
        /// <param name="construtor"></param>
        public void Configure(EntityTypeBuilder<Noticia> construtor)
        {
            //Nome da tabela
            construtor.ToTable("Noticias");

            //Definição da chave primaria, índices e nomes dos mesmos
            construtor.HasKey(n => n.NoticiaId)
                .HasName("PK_Noticias_NoticiaId")
                .ForSqlServerIsClustered();

            construtor.HasIndex(n => n.NoticiaId)
                .HasName("IX_Noticias_NoticiaId")
                .IsUnique();

            //Definição das propriedades no banco de dados
            construtor.Property(n => n.NoticiaId)
                .UseSqlServerIdentityColumn()
                .ValueGeneratedOnAdd();

            construtor.Property(n => n.Titulo)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            construtor.Property(n => n.ChamadaSocial)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            construtor.Property(n => n.DataCadastro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            construtor.Property(e => e.Autor)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .HasDefaultValue("Anônimo");

            construtor.Property(e => e.TextoMateria)
                .HasColumnType("varchar(max)")
                .IsRequired();

            construtor.Property(n => n.Imagem)
                .HasColumnType("image")
                .IsRequired();

            ////Relacionamentos: N-notícias em 1 determinado local
            //construtor.HasOne(n => n.Mapa)
            //    .WithMany(n => n.Noticias)
            //    .HasForeignKey(n => n.MapaId)
            //    .HasConstraintName("FK_Noticias_Mapas_MapaId");
        }
    }
}
