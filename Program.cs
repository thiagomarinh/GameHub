using GameHub.Entities;

namespace GameHub
{
    class Program
    {
        public static void Main(string[] args)
        {
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();


            Console.WriteLine("----Bem vindo ao jogo da Velha----");
            Console.WriteLine();

            Console.WriteLine("Digite o nome do primeiro jogador X: ");
            jogador1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do primeiro jogador O: ");
            jogador2.Nome = Console.ReadLine();

            
            TabuleiroJogoDaVelha tabuleiroVelha = new TabuleiroJogoDaVelha(3, 3);
            tabuleiroVelha.MostrarTabuleiro();
            Console.WriteLine();

            do
            {
                Console.Write("jogada X:");
                string jogada1 = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("--- Voces estao jogando o jogo da Velha ---");
                Console.WriteLine("");
                tabuleiroVelha.FazerJogada(jogada1, "X");

                Console.Write("Jogada O:");
                string jogada2 = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("--- Voces estao jogando o jogo da Velha ---");
                Console.WriteLine("");
                tabuleiroVelha.FazerJogada(jogada2, "O");

            } while (true);


        }
    }
}
