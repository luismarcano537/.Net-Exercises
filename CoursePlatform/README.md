
# CoursePlatform - Contagem de Alunos Únicos

### Objetivo
O objetivo deste projeto é implementar uma solução em C# para calcular o número total de alunos únicos matriculados em múltiplos cursos. A aplicação simula um cenário onde um instrutor possui três cursos (A, B e C) e precisa saber sua quantidade total de estudantes, desconsiderando as matrículas duplicadas (alunos que fazem mais de um curso).

### Desafio
Em um portal de cursos online, cada usuário possui um código único (um número inteiro). Um instrutor (Alex) pode ter vários cursos, e um mesmo aluno pode se matricular em quantos cursos quiser.

O desafio é implementar um programa que:

Leia os códigos dos alunos matriculados no Curso A.

Leia os códigos dos alunos matriculados no Curso B.

Leia os códigos dos alunos matriculados no Curso C.

Calcule e exiba o número total de alunos distintos que o instrutor possui, somando os três cursos.

### Exemplo de funcionamento

```text
How many students for course A? 3
21
35
22
How many students for course B? 2
21
50
How many students for course C? 3
42
35
13
Total students: 6
```

### Instruções de uso
Para conseguir executar o sistema desenvolvido será **necessário** que tenha instalado o **.NET SDK** na sua máquina, você pode baixalo no site oficial da Microsoft. 

**Clone o repositorio na sua máquina:** 

```
git clone https://github.com/luismarcano537/.Net-Exercises.git
```
Navegue para a pasta do exercício específico:
```
cd .Net-Exercises/OOP-OrderManagement
```
Execute o programa com o comando: 
```
dotnet run
```
### Fontes

Este exercicio foi oferecido pelo Professor Nelio Alves no curso C# e OO: composição, herança, coleções, arquivos, LINQ, lambda, delegates e muito mais disponível na plataforma Udemy. 

### Tecnologias e conceitos utilizados
+ Linguagem: C#

+ Plataforma: .NET

+ Estrutura de Dados Chave: HashSet<int>

A coleção HashSet (Conjunto Hash) foi a escolha central para este problema. Sua principal característica é a garantia de unicidade dos elementos: ele não permite a adição de valores duplicados.

+ Conceitos aplicados:

Uso de Coleções (Collections) genéricas.

Método UnionWith() para combinar múltiplos conjuntos (HashSet), mantendo apenas os elementos únicos de todas as coleções.

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**