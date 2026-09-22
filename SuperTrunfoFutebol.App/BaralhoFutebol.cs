using System;
using System.Collections.Generic;

namespace SuperTrunfoFutebol
{
    public static class BaralhoFutebol
    {
        public static List<Jogador> CriarBaralho()
        {
            List<Jogador> cartas = new List<Jogador>();

            cartas.Add(new Jogador("Pelé", "Santos", "Atacante", 80, 3, 40, 100));
            cartas.Add(new Jogador("Ronaldo Fenômeno", "Seleção Brasileira", "Atacante", 62, 2, 31, 97));
            cartas.Add(new Jogador("Zico", "Flamengo", "Meia", 66, 0, 20, 93));
            cartas.Add(new Jogador("Romário", "Seleção Brasileira", "Atacante", 55, 1, 14, 95));
            cartas.Add(new Jogador("Ronaldinho Gaúcho", "Seleção Brasileira", "Meia", 33, 1, 20, 94));
            cartas.Add(new Jogador("Garrincha", "Botafogo", "Ponta", 17, 2, 27, 92));
            cartas.Add(new Jogador("Neymar Jr", "Santos", "Atacante", 77, 0, 59, 93));
            cartas.Add(new Jogador("Cafu", "São Paulo", "Lateral", 5, 2, 32, 88));
            cartas.Add(new Jogador("Rivaldo", "Palmeiras", "Meia", 35, 1, 17, 90));
            cartas.Add(new Jogador("Kaká", "Milan", "Meia", 30, 0, 25, 91));

            return cartas;
        }

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
