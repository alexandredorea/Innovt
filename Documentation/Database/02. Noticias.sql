--Definição de qual banco construir as tabelas
USE [Innovt]
GO

--Criação da tabela de Notícias
CREATE TABLE [dbo].[Noticias](
	[NoticiaId]     [int]          NOT NULL IDENTITY(1,1),
	[Titulo]        [varchar](100) NOT NULL,
	[ChamadaSocial] [varchar](100) NOT NULL,
	[DataCadastro]  [datetime]     NULL,
	[Autor]         [varchar](50)  NULL,
	[TextoMateria]  [varchar](max) NOT NULL,
	[Imagem]        [image]        NOT NULL,
	[MapaId]        [int]          NOT NULL,
 CONSTRAINT [PK_Noticias_NoticiaId] PRIMARY KEY CLUSTERED ([NoticiaId] ASC)
)
GO

--Definição dos índices da tabela
CREATE INDEX [IX_Noticias_MapaId] 
  ON [dbo].[Noticias] ([MapaId]) 
GO
CREATE INDEX [IX_Noticias_NoticiaId] 
  ON [dbo].[Noticias] ([NoticiaId]) 
GO

--Definição dos valores padrão para o caso de não serem preenchidos
ALTER TABLE [dbo].[Noticias] 
  WITH CHECK ADD CONSTRAINT [DF_Noticias_DataCadastro] DEFAULT (GETDATE()) FOR [DataCadastro]
GO
ALTER TABLE [dbo].[Noticias] 
  WITH CHECK ADD CONSTRAINT [DF_Noticias_Autor] DEFAULT ('Anônimo') FOR [Autor]
GO

--Definiação dos relacionamentos entre as tabelas
ALTER TABLE [dbo].[Noticias]
  WITH CHECK ADD CONSTRAINT [FK_Noticias_Mapas_MapaId] FOREIGN KEY ([MapaId])
  REFERENCES [dbo].[Mapas]([MapaId])
GO
ALTER TABLE [dbo].[Noticias] 
  CHECK CONSTRAINT [FK_Noticias_Mapas_MapaId]
GO