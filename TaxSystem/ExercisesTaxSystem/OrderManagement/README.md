
# Sistema Gerenciador de pedidos.

### Objetivo
Este exercicio desenvolvido em **.Net/C#** planeja por em pratica conceitos básicos da linguagem com recursos da **Programação orientada a Objetos (OOP)** em especifico a Composição e Enumerações. 

### Desafio
O exercicio proposto consiste em criar um sistema onde o usuário possa inserir dados de um pedido com N itens (N forcedido pelo usuário). Depois, mostrar um sumário do pedido conforme o exemplo (Veja mais abaixo). Nota: O momento de criação do pedido foi capturado com DateTime.Now

### Exemplo de funcionamento

```text
Enter cliente data:
Name: Alex Green
Email: alex@gmail.com
Birthdate (DD/MM/YYYY): 15/03/1985
Enter order data:
Status: Processing
How many items to this order? 2
Enter #1 item data: 
Product name: TV
Product price: 1000.00
Quantity: 1
Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2
ORDER SUMMARY:
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
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

### Futuras atualizações
Devido ao exercicio ser oferecido pelo curso em andamento foquei em cumprir apenas os requisitos necessários para concluir o desafio, porém, o sistema será atualizado utilizando os seguintes recursos: 

+ Uso de Switch Case para criar um menu iterativo.
+ Tratativas de erros com Try Catch.

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**