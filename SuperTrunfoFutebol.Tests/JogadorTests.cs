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
            catch (AtributoInvalidoException)
            {
                // Exceção esperada
            }
        }

        [TestMethod]
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
            catch (AtributoInvalidoException)
            {
                // Exceção esperada
            }
        }
    }
}
