using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Innovt.Infraestrutura.Dados.Migrations
{
    public partial class Inicial : Migration
    {
        /// <summary>
        /// Update do banco de dados
        /// </summary>
        /// <param name="migrationBuilder">Construtor da migração</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region Tabela de Mapas

            migrationBuilder.CreateTable(
                name: "Mapas",
                columns: table => new
                {
                    MapaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Longetude = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mapas_MapaId", x => x.MapaId)
                        .Annotation("SqlServer:Clustered", true);
                });

            #endregion

            #region Tabela de Notícias

            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    NoticiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChamadaSocial = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Autor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValue: "Anônimo"),
                    TextoMateria = table.Column<string>(type: "varchar(max)", nullable: false),
                    Imagem = table.Column<byte[]>(type: "image", nullable: false),
                    MapaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias_NoticiaId", x => x.NoticiaId)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Noticias_Mapas_MapaId",
                        column: x => x.MapaId,
                        principalTable: "Mapas",
                        principalColumn: "MapaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mapas_MapaId",
                table: "Mapas",
                column: "MapaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_MapaId",
                table: "Noticias",
                column: "MapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_NoticiaId",
                table: "Noticias",
                column: "NoticiaId",
                unique: true);

            #endregion
        }

        /// <summary>
        /// Downgrade do banco de dados
        /// </summary>
        /// <param name="migrationBuilder">Construtor da migração</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.DropTable(
                name: "Mapas");
        }
    }
}
