
# Employee Salary Analysis (LINQ & Lambda)

## Descrição
Aplicação de console em C# focada em manipulação de dados de funcionários utilizando **LINQ** e **Expressões Lambda**. O sistema processa um arquivo `.csv` contendo informações de funcionários (Nome, Email, Salário) e realiza consultas dinâmicas baseadas em input do usuário.

O objetivo do exercício foi praticar a filtragem, ordenação alfabética e operações de agregação (`Sum`) em coleções de objetos.

## Tecnologias Utilizadas
* **C# / .NET**
* **LINQ:** Utilizado para `Where` (filtragem), `OrderBy` (ordenação) e `Sum` (agregação).
* **File I/O:** Leitura de streams de arquivos.
* **Globalization:** Tratamento correto de separadores decimais internacionais.

## Funcionalidades

- [x] Leitura de base de dados via arquivo `.csv`.
- [x] Input de valor de referência salarial pelo usuário.
- [x] **Relatório de Emails:** Filtra funcionários com salário superior ao valor informado e exibe os e-mails em ordem alfabética.
- [x] **Soma Condicional:** Calcula o somatório dos salários de todos os funcionários cujo nome começa com a letra 'M'.

## Como Executar

1. **Pré-requisitos:** Tenha o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. **Clone o repositório:**
```bash
   git clone [(https://github.com/luismarcano537/.Net-Exercises/tree/main/ExerciseLambda02)]
```

Crie um arquivo de dados (ex: in.csv):
```
Maria,maria@gmail.com,3200.00
Alex,alex@gmail.com,1900.00
Marco,marco@gmail.com,1700.00
Bob,bob@gmail.com,3500.00
Anna,anna@gmail.com,2800.00
```

Execute o projeto:

```
dotnet run
```
Interação:
- Informe o caminho do arquivo.
- Informe o salário base para o filtro (ex: 2000.00).


### Aprendizados
A implementação reforçou o uso de Encadeamento de Métodos LINQ (Method Chaining) para criar consultas limpas e legíveis, evitando laços foreach complexos para operações de conjunto.

Desenvolvido por Luis Marcano durante estudos de C#.

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**