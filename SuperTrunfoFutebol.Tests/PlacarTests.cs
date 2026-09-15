using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperTrunfoFutebol;

namespace SuperTrunfoFutebol.Tests
{
    [TestClass]
    public class PlacarTests
    {
        [TestMethod]
        public void TesteRegistrarRodada_Jogador()
        {
            // Conferir de ao registro de vitória de jogador, é incrementado ao placar do jogador.

            // Cenário
            Placar placar = new Placar();

            // Ação
            placar.RegistrarRodada("jogador");

            // Verificação
            Assert.AreEqual(1, placar.PontosJogador);
        }

        [TestMethod]
        public void TesteRegistrarRodada_Empate()
        {
            // Conferir se ao registrar empate, é incrementado ao placar de empate.

            // Cenário
            Placar placar = new Placar();

            // Ação
            placar.RegistrarRodada("empate");

            // Verificação
            Assert.AreEqual(1, placar.Empates);
        }

        [TestMethod]
        public void TesteRegistrarRodada_Excecao()
        {
            // Conferir se registrar um vencedor inválido, é lançado uma exceção.

            // Cenário
            Placar placar = new Placar();
            bool erroEsperado = false;

            // Ação
            try
            {
                placar.RegistrarRodada("time_fantasma");
            }
            catch (ArgumentException)
            {
                erroEsperado = true;
            }

            // Verificação
            Assert.AreEqual(true, erroEsperado);
        }
    }
}