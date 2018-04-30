--Defini��o de qual banco construir as tabelas
USE [Innovt]
GO

--Cria��o da tabela de Not�cias
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

--Defini��o dos �ndices da tabela
CREATE INDEX [IX_Noticias_MapaId] 
  ON [dbo].[Noticias] ([MapaId]) 
GO
CREATE INDEX [IX_Noticias_NoticiaId] 
  ON [dbo].[Noticias] ([NoticiaId]) 
GO

--Defini��o dos valores padr�o para o caso de n�o serem preenchidos
ALTER TABLE [dbo].[Noticias] 
  WITH CHECK ADD CONSTRAINT [DF_Noticias_DataCadastro] DEFAULT (GETDATE()) FOR [DataCadastro]
GO
ALTER TABLE [dbo].[Noticias] 
  WITH CHECK ADD CONSTRAINT [DF_Noticias_Autor] DEFAULT ('An�nimo') FOR [Autor]
GO

--Definia��o dos relacionamentos entre as tabelas
ALTER TABLE [dbo].[Noticias]
  WITH CHECK ADD CONSTRAINT [FK_Noticias_Mapas_MapaId] FOREIGN KEY ([MapaId])
  REFERENCES [dbo].[Mapas]([MapaId])
GO
ALTER TABLE [dbo].[Noticias] 
  CHECK CONSTRAINT [FK_Noticias_Mapas_MapaId]
GO