# Vote counting system - Sistema para contagem de Votos

Este projeto é uma aplicação console em C# para consolidar os votos de uma eleição a partir de um arquivo de entrada no formato .csv

### Objetivo
O objetivo deste exercício é desenvolver uma aplicação console em C# que processa um arquivo de texto (em formato similar a CSV) contendo registros de votação. A aplicação deve ler este arquivo, agregar os votos por candidato e, ao final, exibir um relatório consolidado no console com o total de votos de cada um.

### Desafio
Na contagem de votos de uma eleição, são gerados vários registros de votação contendo o nome do candidato e a quantidade de votos (formato .csv) que ele obteve em uma urna de votação. Você deve fazer um programa para ler os registros de votação a partir de um arquivo, e daí gerar um relatório consolidado com os totais de cada candidato.

### Exemplo de funcionamento

O programa solicita o caminho de um arquivo de entrada e, em seguida, processa os dados para exibir o total.

Arquivo de entrada (ex: in.txt):
```text
Alex Blue,15
Maria Green,22
Bob Brown,21
Alex Blue,30
Bob Brown,15
Maria Green,27
Maria Green,22
Bob Brown,25
Alex Blue,31
```

Execução do programa no console:

```text
Enter the file path: c:\temp\in.txt
Alex Blue: 76
Maria Green: 71
Bob Brown: 61
```


### Instruções de uso
Para conseguir executar o sistema desenvolvido será **necessário** que tenha instalado o **.NET SDK** na sua máquina, você pode baixalo no site oficial da Microsoft. 

+ Clone este repositório.

+ Compile e execute o projeto (por exemplo, usando o Visual Studio ou o comando dotnet run).

+ Crie um arquivo .txt local contendo os registros de votação, seguindo o formato NomeDoCandidato,votos.

+ Ao executar o programa, insira o caminho completo (full path) para o arquivo de entrada quando solicitado.

O console exibirá o relatório consolidado de votos.

### Fontes

Este exercicio foi oferecido pelo Professor Nelio Alves no curso C# e OO: composição, herança, coleções, arquivos, LINQ, lambda, delegates e muito mais disponível na plataforma Udemy. 

### Tecnologias e conceitos utilizados
+ Linguagem: C#

+ Plataforma de desenvolvimento: .NET

+ Dictionary<string, int>: Estrutura de dados (dicionário) fundamental para esta solução. Foi usada para armazenar e agregar os votos, onde a Chave (string) é o nome do candidato e o Valor (int) é a soma total dos seus votos.

+ StreamReader: Classe utilizada para ler o arquivo de texto linha por linha de forma eficiente.

+ Bloco using: Garante o gerenciamento correto de recursos e o fechamento automático do StreamReader (implementando IDisposable), mesmo se ocorrerem exceções.

+ Tratamento de Exceções (try-catch): Bloco utilizado para capturar e informar erros de I/O (Input/Output), como um arquivo não encontrado (IOException).

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**