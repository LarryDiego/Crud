namespace Crud.Models
{
    public class Jogo
    {
        private static int idAtual = 1;
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Jogo(string nome, decimal preco)
        {
            Id = idAtual;
            Nome = nome;
            idAtual++;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Preço: R$ {Preco.ToString("F2")}"
        }
    }
}