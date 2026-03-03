# Exercícios de Vetores em C# 🚀

Este repositório contém resoluções de exercícios práticos focados em **manipulação de arrays**, **lógica de programação** e **orientação a objetos** na linguagem C#.

## 📂 Descrição dos Projetos

O repositório está organizado em três desafios distintos que demonstram o uso de vetores:

### 1. Cálculo de Média de Alturas (`Program.cs`)
* **Objetivo**: Ler um número inteiro $N$ e as alturas de $N$ pessoas.
* **Funcionamento**: Armazenar os valores em um vetor de tipos primitivos (`double[]`), calcular a soma total e a média aritmética.
* **Conceitos**: Declaração de vetores, laços `for` e saída formatada com `CultureInfo`.

### 2. Gestão de Produtos (`Product.cs` e `vetor2.cs`)
* **Objetivo**: Gerenciar uma lista de produtos com nomes e preços.
* **Funcionamento**: Utilizar um vetor de objetos da classe `Product` para armazenar os dados de entrada e calcular o preço médio da lista.
* **Conceitos**: Classes com propriedades auto-implementadas (`{ get; set; }`) e manipulação de vetores de tipos referência.

### 3. Sistema de Pensionato (`Estudante.cs` e `vetor3.cs`)
* **Objetivo**: Controlar o aluguel de 10 quartos (índices 0 a 9).
* **Funcionamento**:
    * **Validar** se o quarto escolhido está entre o intervalo permitido e se está vago.
    * **Verificar** a disponibilidade da vaga (`vet[quarto] != null`) antes de confirmar o aluguel.
    * **Listar** apenas os quartos ocupados ao final do programa utilizando o método `ToString()`.
* **Conceitos**: Construtores personalizados, verificação de nulos em arrays, `override` de métodos e lógica de validação com `while`.

## 🛠️ Tecnologias
* **Linguagem**: C# (.NET)
* **IDE**: Visual Studio / VS Code
* **Versionamento**: Git e GitHub

## 🚀 Como baixar e rodar
1. **Clonar** o repositório:
   ```bash
   git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
