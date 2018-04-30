--Definição de qual banco construir as tabelas
USE [Innovt]
GO

--Criação da tabela de Mapas
CREATE TABLE [dbo].[Mapas](
	[MapaId]    [int]         NOT NULL IDENTITY(1,1),
	[Latitude]  [varchar](20) NOT NULL,
	[Longetude] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Mapas_MapaId] PRIMARY KEY CLUSTERED ([MapaId] ASC)
)
GO

--Definição dos índices da tabela
CREATE INDEX [IX_Mapas_MapaId] 
  ON [dbo].[Mapas] ([MapaId] ASC)
GO