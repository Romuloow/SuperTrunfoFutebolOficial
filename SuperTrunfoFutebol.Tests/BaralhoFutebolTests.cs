using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperTrunfoFutebol;

namespace SuperTrunfoFutebol.Tests
{
    [TestClass]
    public class BaralhoFutebolTests
    {
        [TestMethod]
        public void TesteCriarBaralho()
        {
            // Verificar se o baralho tem 10 cartas

            // Cenário + Ação
            List<Jogador> baralho = BaralhoFutebol.CriarBaralho();

            // Verificação
            Assert.AreEqual(10, baralho.Count);
        }

        [TestMethod]
        public void TesteEmbaralhar()
        {
            // Verificar se o baralho segue tendo 10 cartas após embaralhar

            // Cenário
            List<Jogador> baralho = BaralhoFutebol.CriarBaralho();
            int quantidadeAntes = baralho.Count;

            // Ação
            BaralhoFutebol.Embaralhar(baralho);

            // Verificação
            Assert.AreEqual(quantidadeAntes, baralho.Count);
        }
    }
}