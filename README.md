# Health Search

Sistema acadêmico de recuperação de informação para artigos científicos em saúde, desenvolvido em .NET com Blazor WebAssembly.

## Objetivo

O projeto organiza a indexação, o armazenamento e a recuperação de documentos por meio de dois modelos:

- Booleano
- Espaço vetorial

Também inclui avaliação de resultados com consultas de teste e métricas de precisão, recall e F1.

## Requisitos

- .NET SDK 10.0 ou superior
- Navegador moderno

## Instalação

1. Abra o terminal na pasta do projeto.
2. Restaure os pacotes:
   
   dotnet restore

3. Execute a aplicação:

   dotnet run

## Funcionamento

1. Na aba de indexação, carregue os PDFs e o arquivo de stopwords.
2. Ajuste os dados extraídos, se necessário.
3. Clique em "Iniciar indexação" para processar os resumos.
4. Consulte os artigos na aba de recuperação.
5. Execute os testes para comparar os modelos e os julgamentos manuais.

## Observações

- O cálculo do TF, TF normalizado, DF, IDF e TF-IDF é implementado manualmente.
- Os arquivos de frequência são exportados em .txt com o DocId correspondente.
- O sistema preserva acentuação e trata hífens como parte dos termos.
