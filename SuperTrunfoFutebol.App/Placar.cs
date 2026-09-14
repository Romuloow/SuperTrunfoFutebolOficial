using System;

namespace SuperTrunfoFutebol
{
    public class Placar
    {
        public int PontosJogador { get; private set; }
        public int PontosComputador { get; private set; }
        public int Empates { get; private set; }

        public void RegistrarRodada(string vencedor)
        {
            if (vencedor == "jogador")
            {
                PontosJogador++;
            }
            else if (vencedor == "computador")
            {
                PontosComputador++;
            }
            else if (vencedor == "empate")
            {
                Empates++;
            }
            else
            {
                throw new ArgumentException("Vencedor inválido. Use 'jogador', 'computador' ou 'empate'.");
            }
        }

        public void ExibirResultado()
        {
            Console.WriteLine($"Placar -> Você: {PontosJogador} | Computador: {PontosComputador} | Empates: {Empates}");
        }
    }
}
