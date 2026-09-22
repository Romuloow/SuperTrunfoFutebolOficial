using System;
using System.Collections.Generic;

namespace SuperTrunfoFutebol
{
    public static class BaralhoFutebol
    {
        public static List<Jogador> CriarBaralho()
        {
            List<Jogador> cartas = new List<Jogador>();

            cartas.Add(new Jogador("Pelé", "Santos", "Atacante", 1281, 3, 350, 100));
            cartas.Add(new Jogador("Ronaldo Fenômeno", "Cruzeiro", "Atacante", 414, 2, 98, 98));
            cartas.Add(new Jogador("Zico", "Flamengo", "Meia", 826, 0, 270, 97));
            cartas.Add(new Jogador("Romário", "Vasco", "Atacante", 1002, 1, 150, 97));
            cartas.Add(new Jogador("Garrincha", "Botafogo", "Atacante", 245, 2, 110, 96));
            cartas.Add(new Jogador("Ronaldinho Gaúcho", "Atlético Mineiro", "Meia", 313, 1, 192, 95));
            cartas.Add(new Jogador("Rivellino", "Fluminense", "Meia", 175, 1, 140, 93));
            cartas.Add(new Jogador("Sócrates", "Corinthians", "Meia", 292, 0, 120, 92));
            cartas.Add(new Jogador("Cafu", "São Paulo", "Lateral", 37, 2, 130, 90));
            cartas.Add(new Jogador("Fred", "Fluminense", "Atacante", 412, 0, 101, 89));

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
