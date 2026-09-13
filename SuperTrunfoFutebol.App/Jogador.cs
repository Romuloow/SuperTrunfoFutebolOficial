using System;

namespace SuperTrunfoFutebol
{
    // Classe pública que representa uma carta do Super Trunfo (um jogador de futebol).
    // Cada carta tem informações básicas e 4 atributos numéricos usados na disputa.
    public class Jogador
    {
        public string Nome { get; set; }
        public string Time { get; set; }
        public string Posicao { get; set; }
        public int Gols { get; set; }
        public int Copas { get; set; }
        public int Assistencias { get; set; }
        public int NotaGeral { get; set; }

        // Construtor: recebe os dados da carta e valida se fazem sentido.
        // Se algum valor for inválido, uma exceção é lançada (tratamento de exceções).
        public Jogador(string nome, string time, string posicao, int gols, int copas, int assistencias, int notaGeral)
        {
            if (notaGeral < 0 || notaGeral > 100)
            {
                throw new AtributoInvalidoException("A nota geral deve estar entre 0 e 100.");
            }

            if (gols < 0 || copas < 0 || assistencias < 0)
            {
                throw new AtributoInvalidoException("Os atributos numéricos não podem ser negativos.");
            }

            Nome = nome;
            Time = time;
            Posicao = posicao;
            Gols = gols;
            Copas = copas;
            Assistencias = assistencias;
            NotaGeral = notaGeral;
        }

        // Mostra a carta inteira no console, com todos os atributos.
        public void ExibirCarta()
        {
            Console.WriteLine($"----- {Nome} -----");
            Console.WriteLine($"Time: {Time}");
            Console.WriteLine($"Posição: {Posicao}");
            Console.WriteLine($"1 - Gols: {Gols}");
            Console.WriteLine($"2 - Copas do Mundo: {Copas}");
            Console.WriteLine($"3 - Assistências: {Assistencias}");
            Console.WriteLine($"4 - Nota Geral: {NotaGeral}");
            Console.WriteLine("---------------------");
        }

        // Retorna o valor do atributo escolhido (1 a 4).
        // Se a opção não existir, lança uma exceção personalizada.
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
                    throw new AtributoInvalidoException("Opção de atributo inválida. Escolha um número entre 1 e 4.");
            }
        }
    }
}
