    using System;

    namespace SuperTrunfoFutebol
    {

        public class Jogador
        {
            public string Nome { get; set; }
            public string Time { get; set; }
            public string Posicao { get; set; }
            public int Gols { get; set; }
            public int Copas { get; set; }
            public int Assistencias { get; set; }
            public int NotaGeral { get; set; }

            public Jogador(string nome, string time, string posicao, int gols, int copas, int assistencias, int notaGeral)
            {
                if (notaGeral < 0 || notaGeral > 100)
                {
                    throw new ArgumentException("A nota geral deve estar entre 0 e 100.");
                }

                if (gols < 0 || copas < 0 || assistencias < 0)
                {
                    throw new ArgumentException("Os atributos numéricos não podem ser negativos.");
                }

                Nome = nome;
                Time = time;
                Posicao = posicao;
                Gols = gols;
                Copas = copas;
                Assistencias = assistencias;
                NotaGeral = notaGeral;
            }

            public void ExibirCarta()
            {
                Console.WriteLine("┌─────────────────────────┐");
                Console.WriteLine($"│ {Nome.PadRight(23)} │");
                Console.WriteLine("├─────────────────────────┤");
                Console.WriteLine($"│ {Time.PadRight(23)} │");
                Console.WriteLine($"│ {Posicao.PadRight(23)} │");
                Console.WriteLine("├─────────────────────────┤");
                Console.WriteLine($"│ 1.Gols.............: {Gols.ToString().PadLeft(3)}  │");
                Console.WriteLine($"│ 2.Copas Mundo......: {Copas.ToString().PadLeft(3)}  │");
                Console.WriteLine($"│ 3.Assistências....: {Assistencias.ToString().PadLeft(3)}  │");
                Console.WriteLine($"│ 4.Nota Geral.......: {NotaGeral.ToString().PadLeft(3)}  │");
                Console.WriteLine("└─────────────────────────┘");
            }

            public int ObterAtributo(int opcao)
            {
                switch (opcao)
                {
                    case 1:
                        return Gols;
                    case 2:
                        return Copas;
                    case 3:
                        return Assistencias;
                    case 4:
                        return NotaGeral;
                    default:
                        throw new ArgumentException("Opção de atributo inválida. Escolha um número entre 1 e 4.");
                }
            }
        }
    }
