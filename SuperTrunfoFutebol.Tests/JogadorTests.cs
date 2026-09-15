using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperTrunfoFutebol;

namespace SuperTrunfoFutebol.Tests
{
    [TestClass]
    public class JogadorTests
    {
        [TestMethod]
        public void TesteCriarJogador()
        {
            // Verificar se o construtor preenche as propriedades corretamente

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
        public void TesteCriarJogador_Excecao()
        {
            // Verificar se criar um jogador com nota 150 dispara uma exceção


            // Cenário:
            string nome = "Jogador Teste";
            string time = "Time A";
            string posicao = "Atacante";
            int gols = 10;
            int copas = 1;
            int assistencias = 10;
            int nota = 150;

            bool erroEsperado = false;

            try
            {
                // Ação
                new Jogador(nome, time, posicao, gols, copas, assistencias, nota);
           
            }
            catch (ArgumentException)
            {
                erroEsperado = true;
            }

            // Verificação -> lançamento de exceção esperado
            Assert.AreEqual(true, erroEsperado);

        }

    }
}
