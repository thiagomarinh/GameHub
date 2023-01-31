using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class TabuleiroJogoDaVelha : Tabuleiro
    {
        public string[,] matriz = { { "7", "8", "9" }, { "4", "5", "6" }, { "1", "2", "3" } };
        public TabuleiroJogoDaVelha(int linhas, int colunas) : base(linhas, colunas)
        {
        }

        public void MostrarTabuleiro()
        {
            for (int i = 0; i < Linhas; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Colunas; j++)
                {
                    Console.Write($" {matriz[i, j]} |");

                }
                Console.WriteLine("");
            }
        }

        public void FazerJogada(string jogada, string peca)
        {
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    if (matriz[i, j] == jogada && peca == "X")
                    {
                        matriz[i, j] = "X";
                        MostrarTabuleiro();

                        if ((matriz[0, 0] == "X" && matriz[0, 1] == "X" && matriz[0, 2] == "X") ||
                            (matriz[1, 0] == "X" && matriz[1, 1] == "X" && matriz[1, 2] == "X") ||
                            (matriz[2, 0] == "X" && matriz[2, 1] == "X" && matriz[2, 2] == "X") ||
                            (matriz[0, 0] == "X" && matriz[1, 0] == "X" && matriz[2, 0] == "X") ||
                            (matriz[0, 1] == "X" && matriz[1, 1] == "X" && matriz[2, 1] == "X") ||
                            (matriz[0, 2] == "X" && matriz[1, 2] == "X" && matriz[2, 2] == "X") ||
                            (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X") ||
                            (matriz[2, 0] == "X" && matriz[1, 1] == "X" && matriz[0, 2] == "X"))
                        {
                            Console.WriteLine($"Parabens X você ganhou");
                        }
                    }

                    if (matriz[i, j] == jogada && peca == "O")
                    {
                        matriz[i, j] = "O";
                        MostrarTabuleiro();

                        if ((matriz[0, 0] == "O" && matriz[0, 1] == "O" && matriz[0, 2] == "O") ||
                            (matriz[1, 0] == "O" && matriz[1, 1] == "O" && matriz[1, 2] == "O") ||
                            (matriz[2, 0] == "O" && matriz[2, 1] == "O" && matriz[2, 2] == "O") ||
                            (matriz[0, 0] == "0" && matriz[1, 0] == "O" && matriz[2, 0] == "O") ||
                            (matriz[0, 1] == "O" && matriz[1, 1] == "O" && matriz[2, 1] == "O") ||
                            (matriz[0, 2] == "O" && matriz[1, 2] == "O" && matriz[2, 2] == "O") ||
                            (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O") ||
                            (matriz[2, 0] == "O" && matriz[1, 1] == "O" && matriz[0, 2] == "O"))
                        {
                            Console.WriteLine($"Parabens O você ganhou");
                        }
                    }


                }
            }
        }
    }
}
