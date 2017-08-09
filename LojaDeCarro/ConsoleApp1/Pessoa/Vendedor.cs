
namespace Cappta.LojaDeCarro.Pessoas
{
  public class Vendedor : IPessoa
    {

        public string nome { get; set; }


        public Vendedor(string nome)
        {
            this.nome = nome;
        }

    }
}
