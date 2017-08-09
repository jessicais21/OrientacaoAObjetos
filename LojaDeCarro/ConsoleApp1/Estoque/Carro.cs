
namespace Cappta.LojaDeCarro.Estoque
{
   public class Carro : IVeiculo
    {
        public string chassi { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public double valor { get; set; }

        
        public Carro(string chassi, string marca, string modelo, string cor,int ano, double valor)
        {
            this.chassi = chassi;
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.valor = valor;

        }

    }
}
