# Especificação

## Página: Cadastro de notícia

Essa página deve permitir o cadastro de uma nova notícia e a exibição de mensagens de erro em caso de preenchimento incorreto dos campos do formulário da página. A pagina deve conter as seguintes informações:

1. Campo de “Título” da notícia (Preenchimento obrigatório pelo usuário)
2. Campo de “Chamada social” da notícia (Preenchimento obrigatório pelo usuário e máximo de 100 caracteres)
3. Campo de “Texto da notícia” (Preenchimento obrigatório pelo usuário)
4. Campo de “Autor” (Preenchimento não é obrigatório – Em caso de não preenchimento, o sistema deve automaticamente preencher esse dado como “Autor Anônimo”)
5. Campo de “Imagem da notícia” (Preenchimento obrigatório pelo usuário)
6. Campo de mapa (Google Maps) para que o usuário clique no ponto que deseja apontar como local do ocorrido relatado na notícia.

## Protótipo

[![Cadastro de notícia](https://github.com/alexandredorea/Innovt/blob/master/Documentation/Mockup/Images/Cadastro%20de%20Not%C3%ADcias.png)


**Observação:**

* Caso o usuário não preencha os campos corretamente, a página deve exibir indicações visuais ou através de textos informando o motivo do erro e o que o usuário tem que preencher corretamente para que a notícia seja enviada.
* Caso o usuário preencha o formulário corretamente, ele deve ser redirecionado para página de “Resumo do envio da notícia”, descrita [aqui](https://github.com/alexandredorea/Innovt/blob/master/Documentation/Especification/02%20-%20Pagina%20de%20resumo%20do%20envio%20da%20noticia.md).