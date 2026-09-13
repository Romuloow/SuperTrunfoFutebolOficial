using System;
using System.Collections.Generic;

namespace SuperTrunfoFutebol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("   SUPER TRUNFO - ÍDOLOS DO FUTEBOL BR");
            Console.WriteLine("=========================================");

            // Cria e embaralha o baralho (uso da classe estática BaralhoFutebol)
            List<Jogador> baralhoCompleto = BaralhoFutebol.CriarBaralho();
            BaralhoFutebol.Embaralhar(baralhoCompleto);

            // Divide as cartas entre você e o computador
            List<Jogador> cartasJogador = new List<Jogador>();
            List<Jogador> cartasComputador = new List<Jogador>();

            for (int i = 0; i < baralhoCompleto.Count; i++)
            {
                if (i % 2 == 0)
                {
                    cartasJogador.Add(baralhoCompleto[i]);
                }
                else
                {
                    cartasComputador.Add(baralhoCompleto[i]);
                }
            }

            Placar placar = new Placar();
            int numeroRodada = 1;

            // Loop principal: continua enquanto os dois ainda tiverem cartas
            while (cartasJogador.Count > 0 && cartasComputador.Count > 0)
            {
                Console.WriteLine($"\n----- RODADA {numeroRodada} -----");

                Jogador cartaJogador = cartasJogador[0];
                Jogador cartaComputador = cartasComputador[0];

                Console.WriteLine("\nSua carta:");
                cartaJogador.ExibirCarta();

                Console.WriteLine($"\nCarta do computador (oculta): {cartaComputador.Nome} - ???");

                int escolha = LerEscolhaAtributo();

                int valorJogador = cartaJogador.ObterAtributo(escolha);
                int valorComputador = cartaComputador.ObterAtributo(escolha);

                Console.WriteLine($"\nCarta do computador revelada: {cartaComputador.Nome}");
                Console.WriteLine($"Valor escolhido -> Você: {valorJogador} | Computador: {valorComputador}");

                // As duas cartas jogadas saem do topo de cada monte
                cartasJogador.RemoveAt(0);
                cartasComputador.RemoveAt(0);

                if (valorJogador > valorComputador)
                {
                    Console.WriteLine("Você venceu a rodada!");
                    cartasJogador.Add(cartaJogador);
                    cartasJogador.Add(cartaComputador);
                    placar.RegistrarRodada("jogador");
                }
                else if (valorComputador > valorJogador)
                {
                    Console.WriteLine("O computador venceu a rodada!");
                    cartasComputador.Add(cartaJogador);
                    cartasComputador.Add(cartaComputador);
                    placar.RegistrarRodada("computador");
                }
                else
                {
                    Console.WriteLine("Empate! Cada um fica com a própria carta.");
                    cartasJogador.Add(cartaJogador);
                    cartasComputador.Add(cartaComputador);
                    placar.RegistrarRodada("empate");
                }

                numeroRodada++;
                placar.ExibirResultado();
            }

            Console.WriteLine("\n===== FIM DE JOGO =====");
            Console.WriteLine(cartasJogador.Count == 0 ? "O computador venceu o jogo!" : "Você venceu o jogo!");
            placar.ExibirResultado();
        }

        // Lê a escolha do atributo digitada pelo usuário.
        // Usa try/catch para tratar entradas inválidas (tratamento de exceções).
        private static int LerEscolhaAtributo()
        {
            while (true)
            {
                Console.WriteLine("\nEscolha o atributo para disputar:");
                Console.WriteLine("1 - Gols | 2 - Copas do Mundo | 3 - Assistências | 4 - Nota Geral");
                string entrada = Console.ReadLine();

                try
                {
                    int escolha = int.Parse(entrada);

                    if (escolha < 1 || escolha > 4)
                    {
                        throw new AtributoInvalidoException("Escolha inválida. Digite um número entre 1 e 4.");
                    }

                    return escolha;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: digite apenas números.");
                }
                catch (AtributoInvalidoException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Catch genérico: protege o programa de qualquer outro erro inesperado
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }
        }
    }
}
