# Super Trunfo - Ídolos do Futebol Brasileiro

Aplicação Console em C# (.NET 8) que simula o jogo Super Trunfo, com cartas de
ídolos do futebol brasileiro.

## Estrutura do projeto

```
SuperTrunfoFutebol.sln
SuperTrunfoFutebol.App/          -> aplicação (o jogo em si)
    Program.cs                   -> loop principal do jogo
    Jogador.cs                   -> classe pública da carta (jogador de futebol)
    BaralhoFutebol.cs            -> classe estática que cria/embaralha o baralho
    Placar.cs                    -> classe pública que guarda a pontuação
    AtributoInvalidoException.cs -> exceção personalizada do jogo
SuperTrunfoFutebol.Tests/        -> testes de unidade (MSTest)
    JogadorTests.cs
    BaralhoFutebolTests.cs
    PlacarTests.cs
```

## Como executar

Pré-requisito: [SDK do .NET 8](https://dotnet.microsoft.com/download) instalado.

```bash
# Restaurar os pacotes (baixa as dependências do NuGet)
dotnet restore

# Rodar o jogo
dotnet run --project SuperTrunfoFutebol.App

# Rodar os testes de unidade
dotnet test
```

> Se o `dotnet restore` reclamar da versão exata do pacote `MSTest` (as
> versões do NuGet mudam com o tempo), rode `dotnet add SuperTrunfoFutebol.Tests
> package MSTest` dentro da pasta do projeto para instalar a versão mais
> recente automaticamente, sem precisar editar o .csproj na mão.

## Como o jogo funciona

1. O baralho tem 10 cartas de ídolos do futebol brasileiro (Pelé é a carta
   "Super Trunfo", com a maior nota geral).
2. As cartas são embaralhadas e divididas: metade para você, metade para o
   computador.
3. A cada rodada, você vê sua carta e escolhe um atributo (Gols, Copas do
   Mundo, Assistências ou Nota Geral) para disputar contra a carta oculta do
   computador.
4. Quem tiver o maior valor no atributo escolhido vence a rodada e leva as
   duas cartas. Em caso de empate, cada um fica com a própria carta.
5. O jogo termina quando um dos dois fica sem cartas.

## Relação com a rubrica

- **Classes**: `Jogador` (classe pública com construtor e métodos) e `Placar`
  (classe pública) demonstram criação de classes; `BaralhoFutebol` é uma
  **classe estática** (usada sem `new`, só com `NomeDaClasse.Metodo()`).
- **Tratamento de exceções**: a classe `AtributoInvalidoException` é uma
  exceção personalizada, lançada quando os dados de uma carta são inválidos
  ou quando o atributo escolhido não existe. O `Program.cs` usa `try/catch`
  para tratar tanto essa exceção quanto erros de digitação do usuário
  (`FormatException`).
- **Testes de unidade**: o projeto `SuperTrunfoFutebol.Tests` usa MSTest,
  com `[TestClass]` e `[TestMethod]`. Cada teste segue o padrão
  Cenário / Ação / Verificação (Arrange / Act / Assert), sempre comentado no
  código.
- **Loop**: usado no loop principal do jogo (`while`), na divisão das cartas
  e no embaralhamento (`for`).

## Possíveis perguntas de defesa (e respostas rápidas)

- **Por que `BaralhoFutebol` é estática?** Porque ela não guarda estado
  próprio — só entrega uma lista de cartas pronta. Não faz sentido criar um
  "objeto BaralhoFutebol", por isso não precisa de `new`.
- **Por que criar uma exceção personalizada em vez de usar só `Exception`?**
  Para deixar claro, pelo nome da exceção, que o erro é específico do jogo
  (dado de carta ou atributo inválido), facilitando o `catch` mais específico
  no `Program.cs`.
- **O que acontece se o usuário digitar uma letra em vez de um número?**
  O `int.Parse` lança `FormatException`, que é capturada no `catch`, e o jogo
  pede a entrada de novo, sem travar.
