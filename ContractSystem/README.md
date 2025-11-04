# Contract System

## Objetivo
O projeto **Contract System** tem como objetivo simular a geração de parcelas de um contrato, aplicando juros e taxas de pagamento com base em um serviço online (neste caso, o **PayPal**).  
A aplicação permite inserir os dados de um contrato e calcular automaticamente as prestações, com data e valor ajustados conforme as regras de juros e taxas estabelecidas.

---

## Desafio
Implementar um sistema orientado a objetos em C# que:
- Leia os dados de um contrato (número, data e valor total);
- Solicite a quantidade de parcelas;
- Gere as parcelas com base em um serviço de pagamento que aplica:
  - **1% de juros simples por mês**;
  - **2% de taxa de pagamento** sobre o valor atualizado.

O programa deve exibir as parcelas calculadas com suas respectivas datas e valores.

---

## Exemplo de funcionamento

**Entrada de dados:**
ENTER CONTRACT DATA:
Number: 8028
Date (dd/MM/yyyy): 25/06/2018
Contract Value: 600.00
Enter number of installments: 3

**Saída esperada:**
Installments:
25/07/2018 - 206.04
25/08/2018 - 208.08
25/09/2018 - 210.12


---

## Instruções de uso

1. Clone o repositório ou baixe os arquivos.
2. Compile e execute o programa no terminal com o comando: dotnet run

3. Insira os dados solicitados:
- Número do contrato;
- Data (no formato **dd/MM/yyyy**);
- Valor total do contrato;
- Quantidade de parcelas.
4. O sistema exibirá as parcelas calculadas com juros e taxas aplicadas.

---

## Tecnologias e conceitos utilizados

- **Linguagem:** C#
- **Paradigma:** Programação Orientada a Objetos (POO)
- **Conceitos aplicados:**
- Encapsulamento  
- Associação entre classes (Composição) 
- Interfaces  
- Injeção de dependência  
- Tratamento de exceções  
- Listas e iteração com `foreach`
- Manipulação de datas e formatação com `DateTime` e `CultureInfo`

---

## Fontes
Este exercício foi proposto pelo **Professor Nélio Alves** no curso  
**“C# e OO: composição, herança, coleções, arquivos, LINQ, lambda, delegates e muito mais”**  
disponível na plataforma Udemy.

---

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**

