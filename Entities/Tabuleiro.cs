namespace GameHub.Entities
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public List<Jogador> Jogadores { get; set; }
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Jogadores = new List<Jogador>();
        }
        
     
    }
}
