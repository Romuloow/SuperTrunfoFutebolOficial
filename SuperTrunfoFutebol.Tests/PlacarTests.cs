using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperTrunfoFutebol;

namespace SuperTrunfoFutebol.Tests
{
    [TestClass]
    public class PlacarTests
    {
        [TestMethod]
        public void RegistrarRodada_VitoriaDoJogador_DeveIncrementarPontosDoJogador()
        {
            // Cenário
            Placar placar = new Placar();

            // Ação
            placar.RegistrarRodada("jogador");

            // Verificação
            Assert.AreEqual(1, placar.PontosJogador);
            Assert.AreEqual(0, placar.PontosComputador);
        }

        [TestMethod]
        public void RegistrarRodada_Empate_DeveIncrementarEmpates()
        {
            // Cenário
            Placar placar = new Placar();

            // Ação
            placar.RegistrarRodada("empate");

            // Verificação
            Assert.AreEqual(1, placar.Empates);
        }

        [TestMethod]
        public void RegistrarRodada_ComVencedorInvalido_DeveLancarExcecao()
        {
            // Cenário
            Placar placar = new Placar();

            // Ação + Verificação
            try
            {
                placar.RegistrarRodada("time_fantasma");
                Assert.Fail("Esperava-se que uma exceção fosse lançada.");
            }
            catch (System.ArgumentException)
            {
                // Exceção esperada
            }
        }
    }
}
