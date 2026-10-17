
using System;
using System.Collections.Generic;

namespace SuperTrunfoFutebol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("┌─────────────────────────────────────────┐");
            Console.WriteLine("│  SUPER TRUNFO - ÍDOLOS DO FUTEBOL BRASIL│");
            Console.WriteLine("└─────────────────────────────────────────┘");
            Console.WriteLine();

            // Cria e embaralha o baralho
            List<Jogador> baralhoCompleto = BaralhoFutebol.CriarBaralho();
            BaralhoFutebol.Embaralhar(baralhoCompleto);

            // Divide as cartas entre o jogador e o computador
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


            // Criação do placar e início do jogo
            Placar placar = new Placar();
            int numeroRodada = 1;

            while (cartasJogador.Count > 0 && cartasComputador.Count > 0)
            {
                Console.WriteLine($"\n╔═════════════════════════════════════════╗");
                Console.WriteLine($"║  RODADA {numeroRodada.ToString().PadLeft(3)}                              ║");
                Console.WriteLine($"╚═════════════════════════════════════════╝");

                Jogador cartaJogador = cartasJogador[0];
                Jogador cartaComputador = cartasComputador[0];

                Console.WriteLine($"Suas cartas: {cartasJogador.Count} | Cartas do computador: {cartasComputador.Count}");

                Console.WriteLine("\n>>> Sua Carta <<<");
                cartaJogador.ExibirCarta();

                //Console.WriteLine($"\nCarta do computador (oculta): {cartaComputador.Nome} - ???");

                int escolha = LerEscolhaAtributo();

                int valorJogador = cartaJogador.ObterAtributo(escolha);
                int valorComputador = cartaComputador.ObterAtributo(escolha);

                Console.WriteLine($"\n>>> Carta do Computador <<<\n{cartaComputador.Nome}");
                Console.WriteLine($"\nValor Escolhido: Você ({valorJogador}) vs Computador ({valorComputador})");

                cartasJogador.RemoveAt(0);
                cartasComputador.RemoveAt(0);

                if (valorJogador > valorComputador)
                {
                    Console.WriteLine("\n✓ Você venceu a rodada!");
                    cartasJogador.Add(cartaJogador);
                    cartasJogador.Add(cartaComputador);
                    placar.RegistrarRodada("jogador");
                }
                else if (valorComputador > valorJogador)
                {
                    Console.WriteLine("\n✗ O computador venceu a rodada!");
                    cartasComputador.Add(cartaJogador);
                    cartasComputador.Add(cartaComputador);
                    placar.RegistrarRodada("computador");
                }
                else
                {
                    Console.WriteLine("\n= Empate! Cada um fica com a própria carta.");
                    cartasJogador.Add(cartaJogador);
                    cartasComputador.Add(cartaComputador);
                    placar.RegistrarRodada("empate");
                }

                numeroRodada++;
                placar.ExibirResultado();
            }

            Console.WriteLine("\n┌─────────────────────────────────────────┐");
            Console.WriteLine("│  FIM DE JOGO                            │");
            Console.WriteLine("└─────────────────────────────────────────┘");
            Console.WriteLine(cartasJogador.Count == 0 ? "\nO computador venceu o jogo!\n" : "\nVocê venceu o jogo!\n");
            placar.ExibirResultado();
        }

        public static int LerEscolhaAtributo()
        {
            while (true)
            {
                Console.WriteLine("\n┌─────────────────────────────────────┐");
                Console.WriteLine("│ Escolha o atributo para disputar:   │");
                Console.WriteLine("├─────────────────────────────────────┤");
                Console.WriteLine("│ 1 - Gols                            │");
                Console.WriteLine("│ 2 - Copas do Mundo                  │");
                Console.WriteLine("│ 3 - Assistências                    │");
                Console.WriteLine("│ 4 - Nota Geral                      │");
                Console.WriteLine("└─────────────────────────────────────┘");
                Console.Write(">>> Digite sua escolha: ");
                string entrada = Console.ReadLine();

                try
                {
                    int escolha = int.Parse(entrada);

                    if (escolha < 1 || escolha > 4)
                    {
                        throw new ArgumentException("Escolha inválida. Digite um número entre 1 e 4.");
                    } 


                    return escolha;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: digite apenas números.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }
        }
    }
}
