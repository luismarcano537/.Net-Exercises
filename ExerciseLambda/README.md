
# Product Data Analysis (LINQ & Lambda)

## Descrição
Este projeto é uma aplicação de console em C# desenvolvida para processar dados de produtos a partir de um arquivo `.csv`. O objetivo é demonstrar a aplicação prática de **Expressões Lambda** e consultas **LINQ** para manipulação de coleções em memória.

O sistema lê um arquivo de entrada contendo nomes e preços de produtos, calcula o preço médio e, em seguida, filtra e ordena os produtos que estão abaixo dessa média.

## Tecnologias Utilizadas
* **C# / .NET**
* **LINQ (Language Integrated Query):** Para filtragem, ordenação e projeção de dados.
* **Expressões Lambda:** Para definição de critérios de busca e seleção de propriedades.
* **File I/O:** Leitura e processamento de arquivos CSV (`StreamReader`).

## Funcionalidades

- [x] **Leitura de Arquivo:** Importa dados de um caminho especificado pelo usuário.
- [x] **Cálculo de Média:** Utiliza `Average()` para determinar o preço médio dos produtos listados.
- [x] **Filtragem Lógica:** Seleciona apenas produtos com preço inferior à média calculada (`Where`).
- [x] **Ordenação:** Organiza os resultados por nome em ordem decrescente (`OrderByDescending`).
- [x] **Tratamento de Exceções:** Implementação básica de robustez com `DefaultIfEmpty` para evitar erros em conjuntos de dados vazios.

## Como Executar

1. **Pré-requisitos:** Tenha o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. **Clone o repositório:**
   ```bash
   git clone [https://github.com/luismarcano537/.Net-Exercises/tree/main/ExerciseLambda)]```

Prepare o arquivo de dados: Crie um arquivo (ex: in.csv) no seguinte formato:

```
Tv,900.00
Mouse,50.00
Tablet,350.50
HD Case,80.90
```

Execute o projeto:
```
dotnet run
```
Entrada: Insira o caminho completo do arquivo quando solicitado no console (ex: C:\temp\in.csv).


### Aprendizados
Este exercício foi fundamental para consolidar a diferença e a aplicação de métodos de extensão do LINQ:

- Entendimento prático de OrderBy vs OrderByDescending para manipulação de listas.

- Uso de delegates (Func<T, TResult>) através de sintaxe Lambda.

- Separação de responsabilidades criando uma entidade de domínio (Product) separada da lógica principal.

Desenvolvido por Luis Marcano durante estudos de Backend C# e .NET.

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**