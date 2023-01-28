
namespace GameHub.Entities
{
    class Jogador
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }

        public Jogador(string nome, int pontuacao)
        {
            Nome = nome;
            Pontuacao = 0;
        }

    }
}
