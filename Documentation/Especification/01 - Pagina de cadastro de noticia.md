# Especifica��o

## P�gina: Cadastro de not�cia

Essa p�gina deve permitir o cadastro de uma nova not�cia e a exibi��o de mensagens de erro em caso de preenchimento incorreto dos campos do formul�rio da p�gina. A pagina deve conter as seguintes informa��es:

1. Campo de �T�tulo� da not�cia (Preenchimento obrigat�rio pelo usu�rio)
2. Campo de �Chamada social� da not�cia (Preenchimento obrigat�rio pelo usu�rio e m�ximo de 100 caracteres)
3. Campo de �Texto da not�cia� (Preenchimento obrigat�rio pelo usu�rio)
4. Campo de �Autor� (Preenchimento n�o � obrigat�rio � Em caso de n�o preenchimento, o sistema deve automaticamente preencher esse dado como �Autor An�nimo�)
5. Campo de �Imagem da not�cia� (Preenchimento obrigat�rio pelo usu�rio)
6. Campo de mapa (Google Maps) para que o usu�rio clique no ponto que deseja apontar como local do ocorrido relatado na not�cia.

## Prot�tipo

[![Cadastro de not�cia](https://github.com/alexandredorea/Innovt/blob/master/Documentation/Mockup/Images/Cadastro%20de%20Not%C3%ADcias.png)


**Observa��o:**

* Caso o usu�rio n�o preencha os campos corretamente, a p�gina deve exibir indica��es visuais ou atrav�s de textos informando o motivo do erro e o que o usu�rio tem que preencher corretamente para que a not�cia seja enviada.
* Caso o usu�rio preencha o formul�rio corretamente, ele deve ser redirecionado para p�gina de �Resumo do envio da not�cia�, descrita [aqui](https://github.com/alexandredorea/Innovt/blob/master/Documentation/Especification/02%20-%20Pagina%20de%20resumo%20do%20envio%20da%20noticia.md).