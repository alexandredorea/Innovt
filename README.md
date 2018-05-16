## Introdução

Este projeto reflete um dos desafios realizados como parte de um processo seletivo para uma empresa na cidade de Salvador-BA.

Buscou-se atender os requisitos solicitados, além de ter sido adicionado conhecimentos como concernentes a gestão de projetos, gerência de configuração, entre outros.



## Desafio: Cadastro de Notícias

[![GitHub issues][ImagemProblema]][Problemas] [![GitHub license][ImagemLicenca]][Licenca]


## Cenário

Você trabalha em um site de notícias de grande importância para sua cidade. O editor do site decidiu que chegou a hora de implementar uma nova funcionalidade que permita que os usuários enviem as notícias da região onde moram para contribuir com o site.

Sua função é programar uma pagina de “Cadastro de Notícia”, onde o usuário irá preencher alguns campos e fazer upload da imagem da notícia.

Após o cadastramento correto, o usuário deve ser redirecionado para uma página informando que a notícia foi cadastrada corretamente e que será avaliada pelos editores do site.


## Especificações

A documentação deste projeto encontram-se dividida em:

1. [Cadastro de Notícia][CadastroNoticias]
2. [Resumo de Envio da Notícia][ResumoNoticias]

## Observação

1. O problema foi resolvido utilizando plataforma web, considerando as tecnologias básicas como HTML, CSS e Javascript, observando as boas práticas de desenvolvimento web;
2. O código “server-side” foi desenvolvido obrigatoriamente em ASP.NET MVC e seguindo convenções REST (preferencialmente);
3. O Layout/Design da página web não era o principal fator de analise para este problema, mas isso não significava que devê-se fazer uma página sem quaisquer critérios para uma boa apresentação visual;
4. Para persistência dos dados foram utilizados Entity Framework Core 2.0 com SQL Server 2017.
5. Foram ainda aplicado para este problema, conceitos de Metodologia Ágil [Kanban e Scrum][ProjetoInnovt], os quais foram definidas as *tasks* para uma melhor organização.


## Recursos utilizados no desenvolvimento da aplicação:

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Visual Studio 2017                        |[Guia][GuiaVS2017]                |[IDE][IDEVS2017]  |
|Linguagem C#                              |[Guia][GuiaCSharp]                |N/A               |
|Conceitos de DDD (Domain Driven Design)   |[Tutorial][GuiaDDD]               |N/A               |
|ASP.NET Core 2.0                          |[Guia][GuiaASPNetCore]            |N/A               |
|Entity Framework Core 2.0                 |[Guia][GuiaEntityCore]            |N/A               |
|Repositório de Dados (Repository Pattern) |[Tutorial][GuiaRepositoryPattern] |N/A               |
|Migration                                 |[Guia][GuiaMigrations]            |N/A               |
|SQL Server 2017                           |[Guia][GuiaSQL2017]               |[IDE][IDESQL2017] |


## Andamento do Projeto

Para se ter uma ideia do andamento do projeto [clique aqui][ProjetoInnovt] e tenha acesso ao **Quadro Kanban** para ver as *Tasks*.


## Ainda tem perguntas ou sugestão de melhoria?

Sinta-se à vontade em abrir um [issue][DefeitoInnovt] ou [Pull Request][PullRequest].



[//]: # (Links de referências para os badges deste repositório)

[ImagemProblema]: <https://img.shields.io/github/issues/alexandredorea/Innovt.svg?style=flat-square>
[Problemas]: <https://github.com/alexandredorea/Innovt/issues>
[ImagemLicenca]: <https://img.shields.io/github/license/alexandredorea/Innovt.svg?style=flat-square>
[Licenca]: <https://github.com/alexandredorea/Innovt/blob/master/LICENSE>



[//]: # (Links de referências para os requisitos do sistema)

[CadastroNoticias]: <https://github.com/alexandredorea/Innovt/blob/master/Documentation/Especification/01%20-%20Pagina%20de%20cadastro%20de%20noticia.md>
[ResumoNoticias]: <https://github.com/alexandredorea/Innovt/blob/master/Documentation/Especification/02%20-%20Pagina%20de%20resumo%20do%20envio%20da%20noticia.md>



[//]: # (Links de referências para o quadro de recursos utilizados)

[GuiaVS2017]: <https://docs.microsoft.com/pt-br/visualstudio/ide/>
[IDEVS2017]: <https://www.visualstudio.com/pt-br/downloads/>
[GuiaCSharp]: <https://docs.microsoft.com/pt-br/dotnet/csharp/>
[GuiaDDD]: <http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/>
[GuiaASPNetCore]: <https://docs.microsoft.com/pt-br/dotnet/core/>
[GuiaEntityCore]: <https://docs.microsoft.com/pt-br/dotnet/framework/>
[GuiaRepositoryPattern]: <https://code.msdn.microsoft.com/windowsdesktop/Implementando-Repositrio-aabcdbce>
[GuiaMigrations]: <https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/>
[GuiaSQL2017]: <https://docs.microsoft.com/pt-br/sql/sql-server/sql-server-technical-documentation>
[IDESQL2017]: <https://www.microsoft.com/pt-br/sql-server/sql-server-downloads>



[//]: # (Links de referências o quadro Kanban do projeto)

[ProjetoInnovt]: <https://github.com/alexandredorea/Innovt/projects/1>



[//]: # (Links de referências aos problemas neste projeto)

[DefeitoInnovt]: <https://github.com/alexandredorea/Innovt/issues>
[PullRequest]: <https://github.com/alexandredorea/Innovt/pulls>