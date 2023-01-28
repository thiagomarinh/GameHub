
namespace GameHub.Entities
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public string[,] matriz = { { "7", "8", "9" }, { "4", "5", "6" }, { "1", "2", "3" } };
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
        }

        public void MostrarTabuleiro()
        {
            for (int i = 0; i < Linhas; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Colunas; j++)
                {
                    Console.Write($" {matriz[i,j]} |");
                    
                }
                Console.WriteLine("");
            }
        }

        // metodo fazer jogada verifica qual 
        public void FazerJogada(string jogada, string peca)
        {
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    if (matriz[i,j] == jogada && peca == "X")
                    {
                        matriz[i, j] = "X";
                        MostrarTabuleiro();
                    }
                    if (matriz[i,j] == jogada && peca == "O")
                    {
                        matriz[i, j] = "O";
                        MostrarTabuleiro();
                    }

                }
                
            }
        }


    }
}
