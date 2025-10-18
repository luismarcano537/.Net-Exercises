# TaxSystem - Cálculo de Impostos (PF e PJ)

Este projeto em C# utiliza **Herança** e **Polimorfismo** para calcular o imposto devido por Pessoas Físicas e Pessoas Jurídicas, com base em suas regras específicas.

##  Objetivo

Ler dados de $N$ contribuintes e, para cada um, calcular o imposto individual e o total geral arrecadado.

## Estrutura Orientada a Objetos

- **Classe Abstrata:** `TaxPayer` (define nome, renda e o método abstrato `Tax()`).
- **Subclasses:** `Individual` e `Company` (implementam `Tax()` com a lógica específica de cada um).

---

## Regras de Cálculo de Imposto

### Pessoa Física (`Individual`)

| Renda Anual | Alíquota | Abatimento |
| :--- | :--- | :--- |
| **< R$ 20.000,00** | 15% | 50% dos gastos com saúde são abatidos. |
| **≥ R$ 20.000,00** | 25% | 50% dos gastos com saúde são abatidos. |

**Fórmula:** `(Renda * Alíquota) - (Gastos com Saúde * 0.50)`

**Exemplo:** Renda R$ 50.000,00, Gastos R$ 2.000,00 $\rightarrow$ **R$ 11.500,00**

### Pessoa Jurídica (`Company`)

| Nº de Funcionários | Alíquota |
| :--- | :--- |
| **≤ 10** | 16% sobre a Renda Anual. |
| **> 10** | 14% sobre a Renda Anual. |

**Fórmula:** `Renda * Alíquota`

**Exemplo:** Renda R$ 400.000,00, 25 Funcionários $\rightarrow$ **R$ 56.000,00**
