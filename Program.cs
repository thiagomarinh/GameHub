using GameHub.Entities;
using System;

namespace GameHub
{
    class Program
    {
        public static void Main(string[] args)
        {

            Tabuleiro tabuleiroVelha = new Tabuleiro(3, 3);

            tabuleiroVelha.MostrarTabuleiro();
            do
            {
                Console.Write("Digite o nome do jogador X: ");
                string jogador1 = Console.ReadLine();

                Console.Write("jogada X:");
                string jogada1 = Console.ReadLine()!;
                tabuleiroVelha.FazerJogada(jogada1, "X");

                Console.Write("Digite o nome do jogador X: ");
                string jogador2 = Console.ReadLine();

                Console.Write("Jogada O:");
                string jogada2 = Console.ReadLine()!;
                tabuleiroVelha.FazerJogada(jogada2, "O");

            } while (true);


        }
    }
}
