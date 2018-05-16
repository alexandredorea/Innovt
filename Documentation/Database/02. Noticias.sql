IF Object_id(N'Innovt.dbo.Noticias', N'U') IS NULL 
  BEGIN 
   
      /** 
       * Definição de qual banco construir a tabela
       */ 
      USE [Innovt] 

      /** 
       * Criação da tabela de Notícias
       */
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
	
	  /** 
       * Definição dos índices da tabela
       */ 
	  CREATE INDEX [IX_Noticias_MapaId] 
	    ON [dbo].[Noticias] ([MapaId]) 
	  CREATE INDEX [IX_Noticias_NoticiaId] 
	    ON [dbo].[Noticias] ([NoticiaId]) 
	
	  /** 
       * Definição dos valores padrão para o caso de não serem preenchidos
       */ 
	  ALTER TABLE [dbo].[Noticias] 
	    WITH CHECK ADD CONSTRAINT [DF_Noticias_DataCadastro] DEFAULT (GETDATE()) FOR [DataCadastro]
	  ALTER TABLE [dbo].[Noticias] 
	    WITH CHECK ADD CONSTRAINT [DF_Noticias_Autor] DEFAULT ('Anônimo') FOR [Autor]

	  /** 
       * Definição dos relacionamentos entre as tabelas
       */ 	
	  ALTER TABLE [dbo].[Noticias]
	    WITH CHECK ADD CONSTRAINT [FK_Noticias_Mapas_MapaId] FOREIGN KEY ([MapaId])
	    REFERENCES [dbo].[Mapas]([MapaId])
	  ALTER TABLE [dbo].[Noticias] 
	    CHECK CONSTRAINT [FK_Noticias_Mapas_MapaId]

  END
GO