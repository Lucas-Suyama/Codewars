# 🧠 Codewars Playground — Treinando Lógica de Programação

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Codewars](https://img.shields.io/badge/Codewars-8A1A1A?style=for-the-badge&logo=codewars&logoColor=white)
![Prática](https://img.shields.io/badge/Pr%C3%A1tica-Di%C3%A1ria-00C853?style=for-the-badge)

Este repositório reúne todos os códigos que desenvolvo no **Codewars** para treinar e aprimorar minha lógica de programação. Cada pasta representa um kata/desafio específico, geralmente implementado como um pequeno projeto console em **C#** com **.NET**.

---

## Índice

- [Introdução](#introdução)
- [Como navegar](#como-navegar)
- [Executar localmente](#executar-localmente)
- [Estrutura dos projetos](#estrutura-dos-projetos)
- [Convenções](#convenções)
- [Perfil no Codewars (opcional)](#perfil-no-codewars-opcional)
- [Próximos passos](#próximos-passos)

---

## Introdução

O objetivo deste repositório é consolidar minhas soluções do Codewars em um só lugar, permitindo:

- Acompanhamento da evolução da minha lógica;
- Revisão e estudo de soluções anteriores;
- Organização por desafio/projeto.

---

## Como navegar

- Cada pasta na raiz (ex.: `Return Negative`, `Even Or Odd`) corresponde a um kata do Codewars.
- Dentro de cada pasta há um `Program.cs` com a solução e um arquivo `.csproj` do projeto.
- Os nomes das pastas normalmente refletem o título do desafio no Codewars.

---

## Executar localmente

Pré-requisitos:

- Instalar o **.NET SDK**: https://dotnet.microsoft.com/download

Passos:

1. Abra o terminal na pasta do desafio desejado (exemplo abaixo no Windows):

   ```powershell
   cd "c:\Users\lucas\Documents\Codewars\Convert a string to an array"
   ```

2. Execute o projeto:

   ```powershell
   dotnet run
   ```

3. Para compilar sem executar:

   ```powershell
   dotnet build
   ```

---

## Estrutura dos projetos

Exemplo de estrutura típica de um kata:

```
Convert a string to an array/
├── Convert a string to an array.csproj
├── Program.cs
└── obj/
```

Outras pastas seguem padrão semelhante, cada uma com seu `Program.cs` e `.csproj`.

---

## Convenções

- Um kata por pasta/projeto.
- Implementações em **C#** usando **.NET** (console apps simples).
- Nomes das pastas inspirados no título do kata no Codewars.

---

## Perfil no Codewars (opcional)

Você pode exibir seu badge do Codewars no início do README. Substitua `<SEU_USUARIO>` pelo seu usuário:

```md
![Codewars Badge](https://www.codewars.com/users/<SEU_USUARIO>/badges/large)
```

Também é possível linkar para seu perfil:

```md
[Meu perfil no Codewars](https://www.codewars.com/users/<SEU_USUARIO>)
```

---

## Próximos passos

- Adicionar mais katas conforme avanço nos desafios.
- Refatorar soluções antigas quando encontrar abordagens melhores.
- (Opcional) Incluir testes unitários com **xUnit** ou **NUnit** para soluções selecionadas.

---

Se quiser trocar ideias sobre lógica ou desafios específicos, sinta-se à vontade para abrir uma discussão ou issue!