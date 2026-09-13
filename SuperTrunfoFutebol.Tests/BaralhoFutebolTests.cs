using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperTrunfoFutebol;

namespace SuperTrunfoFutebol.Tests
{
    [TestClass]
    public class BaralhoFutebolTests
    {
        [TestMethod]
        public void CriarBaralho_DeveRetornarDezCartas()
        {
            // Cenário + Ação
            List<Jogador> baralho = BaralhoFutebol.CriarBaralho();

            // Verificação
            Assert.AreEqual(10, baralho.Count);
        }

        [TestMethod]
        public void CriarBaralho_DeveConterPeleNoBaralho()
        {
            // Cenário + Ação
            List<Jogador> baralho = BaralhoFutebol.CriarBaralho();

            // Verificação
            bool contemPele = baralho.Exists(jogador => jogador.Nome == "Pelé");
            Assert.IsTrue(contemPele);
        }

        [TestMethod]
        public void Embaralhar_NaoDevePerderNenhumaCarta()
        {
            // Cenário
            List<Jogador> baralho = BaralhoFutebol.CriarBaralho();
            int quantidadeAntes = baralho.Count;

            // Ação
            BaralhoFutebol.Embaralhar(baralho);

            // Verificação: embaralhar não pode adicionar nem remover cartas
            Assert.AreEqual(quantidadeAntes, baralho.Count);
        }
    }
}
