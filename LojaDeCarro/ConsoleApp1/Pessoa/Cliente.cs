
namespace Cappta.LojaDeCarro.Pessoas
{
    public class Cliente
    {
        public string rg { get; set; }
        public string nome { get; set; }

        public Cliente(string rg, string nome)
        {

            this.rg = rg;
            this.nome = nome;
        }
    }
}

