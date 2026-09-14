using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperTrunfoFutebol;

namespace SuperTrunfoFutebol.Tests
{
    [TestClass]
    public class JogadorTests
    {
        [TestMethod]
        public void CriarJogador_ComDadosValidos_DevePreencherAtributosCorretamente()
        {
            // Cenário
            string nome = "Pelé";
            string time = "Santos";
            string posicao = "Atacante";
            int gols = 767;
            int copas = 3;
            int assistencias = 200;
            int nota = 100;

            // Ação
            Jogador jogador = new Jogador(nome, time, posicao, gols, copas, assistencias, nota);

            // Verificação
            Assert.AreEqual(nome, jogador.Nome);
            Assert.AreEqual(gols, jogador.Gols);
            Assert.AreEqual(nota, jogador.NotaGeral);
        }

        [TestMethod]
        public void CriarJogador_ComNotaForaDoIntervalo_DeveLancarExcecao()
        {
            // Cenário: nota geral de 150 é inválida (o máximo é 100)
            // Ação + Verificação: espera-se que a exceção seja lançada
            try
            {
                new Jogador("Jogador Teste", "Time Teste", "Atacante", 10, 1, 10, 150);
                Assert.Fail("Esperava-se que uma exceção fosse lançada.");
            }
            catch (ArgumentException)
            {
                // Exceção esperada
            }
        }

        [TestMethod]┌─────────────────────────────────────────────────────────┐
│ INÍCIO: Program.cs > Main() - LINHA 1                   │
└─────────────────────────────────────────────────────────┘
                          ↓
        ┌─────────────────────────────────────┐
        │ Chama BaralhoFutebol.CriarBaralho() │
        │ (Arquivo: BaralhoFutebol.cs)        │
        │                                     │
        │ Cria 10 jogadores Pelé, Ronaldo... │
        │ Retorna List<Jogador> com 10       │
        └─────────────────────────────────────┘
                          ↓
        ┌─────────────────────────────────────┐
        │ Chama BaralhoFutebol.Embaralhar()   │
        │ (Arquivo: BaralhoFutebol.cs)        │
        │                                     │
        │ Fisher-Yates shuffle na lista       │
        └─────────────────────────────────────┘
                          ↓
        ┌─────────────────────────────────────┐
        │ Divide cartas (Program.cs)          │
        │ Loop FOR (pares/ímpares)            │
        │                                     │
        │ Você: 5 cartas                      │
        │ PC: 5 cartas                        │
        └─────────────────────────────────────┘
                          ↓
        ┌─────────────────────────────────────┐
        │ Cria Placar placar = new Placar()   │
        │ (Arquivo: Placar.cs)                │
        └─────────────────────────────────────┘
                          ↓
        ┌──────────────────────────────────────────────────┐
        │ LOOP PRINCIPAL: while (ambos têm cartas)         │
        │ (Program.cs, linhas ~35-92)                      │
        │                                                  │
        │ RODADA 1, 2, 3... enquanto continuar             │
        └──────────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────┐
    │ 1. Pega Jogador cartaJogador (1º da lista)  │
    │ 2. Pega Jogador cartaComputador (1º da PC)  │
    └─────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────────────┐
    │ Chama cartaJogador.ExibirCarta()                    │
    │ (Arquivo: Jogador.cs)                              │
    │                                                     │
    │ Mostra na tela:                                     │
    │ ----- Pelé -----                                    │
    │ Time: Santos                                        │
    │ 1 - Gols: 767                                       │
    │ ...                                                 │
    └─────────────────────────────────────────────────────┘
                          ↓
    ┌────────────────────────────────────────────────────┐
    │ Chama LerEscolhaAtributo()                          │
    │ (Arquivo: Program.cs, método privado)              │
    │                                                    │
    │ Pede entrada do usuário: Digite 1, 2, 3 ou 4      │
    │ Trata FormatException + AtributoInvalidoException │
    │ Retorna int (1-4)                                 │
    └────────────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────────────┐
    │ Chama cartaJogador.ObterAtributo(escolha)           │
    │ (Arquivo: Jogador.cs)                              │
    │                                                     │
    │ Usa switch para retornar:                           │
    │ case 1 → return Gols                               │
    │ case 2 → return Copas                              │
    │ ...                                                 │
    │ Retorna int valorJogador                           │
    └─────────────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────────────┐
    │ Chama cartaComputador.ObterAtributo(escolha)        │
    │ (Arquivo: Jogador.cs)                              │
    │                                                     │
    │ Mesmo processo, retorna valorComputador            │
    └─────────────────────────────────────────────────────┘
                          ↓
    ┌──────────────────────────────────────────────────┐
    │ Compara valores (Program.cs)                    │
    │                                                 │
    │ if (valorJogador > valorComputador)             │
    │   → Você ganhou                                 │
    │ else if (valorComputador > valorJogador)        │
    │   → PC ganhou                                   │
    │ else                                            │
    │   → Empate                                      │
    └──────────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────────────┐
    │ Remove cartas de jogo (Program.cs)                  │
    │                                                     │
    │ cartasJogador.RemoveAt(0)                           │
    │ cartasComputador.RemoveAt(0)                        │
    └─────────────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────────────┐
    │ Chama placar.RegistrarRodada(vencedor)              │
    │ (Arquivo: Placar.cs)                               │
    │                                                     │
    │ if (vencedor == "jogador")                          │
    │   → PontosJogador++                                 │
    │ else if (vencedor == "computador")                  │
    │   → PontosComputador++                              │
    │ else                                                │
    │   → Empates++                                       │
    └─────────────────────────────────────────────────────┘
                          ↓
    ┌─────────────────────────────────────────────────────┐
    │ Chama placar.ExibirResultado()                      │
    │ (Arquivo: Placar.cs)                               │
    │                                                     │
    │ Mostra: Placar → Você: 1 | PC: 0 | Empates: 0     │
    └─────────────────────────────────────────────────────┘
                          ↓
    ┌──────────────────────────────────────────────────┐
    │ numeroRodada++ (próxima rodada)                 │
    │                                                 │
    │ VOLTA AO INÍCIO DO WHILE                        │
    │ Verifica: ambos ainda têm cartas?               │
    │ SIM → Continua loop                             │
    │ NÃO → Sai do loop                               │
    └──────────────────────────────────────────────────┘
                          ↓
        ┌────────────────────────────────────────┐
        │ APÓS LOOP (Program.cs)                 │
        │                                        │
        │ if (cartasJogador.Count == 0)          │
        │   "O computador venceu!"               │
        │ else                                   │
        │   "Você venceu!"                       │
        └────────────────────────────────────────┘
                          ↓
        ┌────────────────────────────────────────┐
        │ Chama placar.ExibirResultado()          │
        │ (Arquivo: Placar.cs)                   │
        │                                        │
        │ Mostra placar final                    │
        └────────────────────────────────────────┘
                          ↓
┌─────────────────────────────────────────────────────┐
│ FIM: Program.cs > Main() - Método termina           │
│ Programa encerra                                    │
└─────────────────────────────────────────────────────┘
        public void CriarJogador_ComGolsNegativos_DeveLancarExcecao()
        {
            // Cenário: quantidade de gols negativa é inválida
            // Ação + Verificação
            try
            {
                new Jogador("Jogador Teste", "Time Teste", "Atacante", -5, 1, 10, 80);
                Assert.Fail("Esperava-se que uma exceção fosse lançada.");
            }
            catch (AtributoInvalidoException)
            {
                // Exceção esperada
            }
        }

        [TestMethod]
        public void ObterAtributo_ComOpcaoValida_DeveRetornarValorCorreto()
        {
            // Cenário
            Jogador jogador = new Jogador("Ronaldinho Gaúcho", "Grêmio", "Meia", 350, 1, 180, 94);

            // Ação
            int valor = jogador.ObterAtributo(3); // 3 = Assistências

            // Verificação
            Assert.AreEqual(180, valor);
        }

        [TestMethod]
        public void ObterAtributo_ComOpcaoInvalida_DeveLancarExcecao()
        {
            // Cenário
            Jogador jogador = new Jogador("Kaká", "Milan", "Meia", 300, 0, 110, 91);

            // Ação + Verificação
            try
            {
                jogador.ObterAtributo(9);
                Assert.Fail("Esperava-se que uma exceção fosse lançada.");
            }
            catch (ArgumentException)
            {
                // Exceção esperada
            }
        }
    }
}
