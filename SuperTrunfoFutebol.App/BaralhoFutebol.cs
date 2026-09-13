using System;
using System.Collections.Generic;

namespace SuperTrunfoFutebol
{
    // Classe estática: não precisa ser instanciada (sem "new").
    // Ela só entrega funcionalidades relacionadas ao baralho de cartas.
    public static class BaralhoFutebol
    {
        // Cria o baralho fixo com 10 ídolos do futebol brasileiro.
        // Pelé é a carta "Super Trunfo" (a de maior nota geral do baralho).
        public static List<Jogador> CriarBaralho()
        {
            List<Jogador> cartas = new List<Jogador>();

            cartas.Add(new Jogador("Pelé", "Santos", "Atacante", 767, 3, 200, 100));
            cartas.Add(new Jogador("Ronaldo Fenômeno", "Seleção Brasileira", "Atacante", 352, 2, 100, 97));
            cartas.Add(new Jogador("Zico", "Flamengo", "Meia", 508, 0, 150, 93));
            cartas.Add(new Jogador("Romário", "Seleção Brasileira", "Atacante", 700, 1, 90, 95));
            cartas.Add(new Jogador("Ronaldinho Gaúcho", "Seleção Brasileira", "Meia", 350, 1, 180, 94));
            cartas.Add(new Jogador("Garrincha", "Botafogo", "Ponta", 232, 2, 85, 92));
            cartas.Add(new Jogador("Neymar Jr", "Santos", "Atacante", 440, 0, 200, 93));
            cartas.Add(new Jogador("Cafu", "São Paulo", "Lateral", 12, 2, 60, 88));
            cartas.Add(new Jogador("Rivaldo", "Palmeiras", "Meia", 380, 1, 120, 90));
            cartas.Add(new Jogador("Kaká", "Milan", "Meia", 300, 0, 110, 91));

            return cartas;
        }

        // Embaralha a lista de cartas (algoritmo de Fisher-Yates, usando um loop "for").
        public static void Embaralhar(List<Jogador> cartas)
        {
            Random sorteio = new Random();

            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = sorteio.Next(0, i + 1);

                Jogador temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }
    }
}
