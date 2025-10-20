# BankAccount - Tratamento de Exceções em C#

### Objetivo
Este exercício desenvolvido em **.Net/C#** tem como finalidade principal praticar o tratamento de erros e exceções. O projeto demonstra a aplicação de `try-catch` para lidar com a robustez do código e a implementação de **exceções de domínio** (`DomainException`) para controlar regras de negócio.

### Desafio
O desafio consiste em simular a criação e uma operação de saque em uma conta bancária. A lógica de saque deve lançar exceções personalizadas sempre que as regras de negócio forem violadas:
1.  **Saldo insuficiente** (`Balance` < valor do saque).
2.  **Limite de saque excedido** (`WithdrawLimit` < valor do saque).

O programa principal deve capturar e tratar essas exceções de domínio, além de tratar exceções genéricas de sistema (`FormatException`, `Exception`).

### Estrutura Orientada a Objetos

A solução está organizada em namespaces (`AccountBanking.Entities`) e classes principais:

| Classe | Finalidade |
| :--- | :--- |
| **`Account`** | Gerencia o estado da conta (número, titular, saldo, limite) e aplica as regras de negócio no método `Withdraw()`. |
| **`DomainException`** | Exceção personalizada (`ApplicationException`) para erros específicos do domínio da conta (saldo ou limite). |

---

## Estratégia de Tratamento de Erros

O programa principal demonstra um tratamento de exceções robusto:

| Tipo de Erro | Bloco `catch` | Exemplo de Mensagem |
| :--- | :--- | :--- |
| **Domínio (Regra de Negócio)** | `catch (DomainException e)` | `Withdraw Error: Not enough balance` |
| **Sistema (Formato de Entrada)** | `catch (FormatException e)` | `Error in format: Input string was not in a correct format.` |
| **Sistema (Geral/Inesperado)** | `catch (Exception e)` | `Unexpected error: ...` |

Esta estrutura garante que a aplicação não falhe e que o usuário receba a informação precisa sobre a natureza do erro.

### Diagrama de Classe `Account`

| Account |
| :--- |
| **Atributos:** |
| - number : Integer |
| - holder : String |
| - balance : Double (ReadOnly) |
| - withdrawLimit : Double (ReadOnly) |
| **Métodos:** |
| + deposit(amount : Double) : void |
| + withdraw(amount : Double) : void |

---