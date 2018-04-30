--Defini��o de qual banco construir as tabelas
USE [Innovt]
GO

--Cria��o da tabela de Mapas
CREATE TABLE [dbo].[Mapas](
	[MapaId]    [int]         NOT NULL IDENTITY(1,1),
	[Latitude]  [varchar](20) NOT NULL,
	[Longetude] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Mapas_MapaId] PRIMARY KEY CLUSTERED ([MapaId] ASC)
)
GO

--Defini��o dos �ndices da tabela
CREATE INDEX [IX_Mapas_MapaId] 
  ON [dbo].[Mapas] ([MapaId] ASC)
GO