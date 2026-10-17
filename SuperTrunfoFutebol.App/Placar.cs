using System;

namespace SuperTrunfoFutebol
{
    public class Placar
    {
        public int PontosJogador { get; set; }
        public int PontosComputador { get; set; }
        public int Empates { get; set; }

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
            Console.WriteLine($"┌──────────────────────────────────────────────────┐");
            Console.WriteLine($"│ Placar  │  Você: {PontosJogador.ToString().PadLeft(2)}  │  PC: {PontosComputador.ToString().PadLeft(2)}  │  Empates: {Empates.ToString().PadLeft(2)}  │");
            Console.WriteLine($"└──────────────────────────────────────────────────┘");
        }
    }
}
