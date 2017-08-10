//namespace utilizado para organização do codigo, pensado no modulo de pessoas
namespace Cappta.LojaDeCarro.Pessoas
{
    //cliente é um objeto do sistema porque ele representa quem compra o carro da concessionária.
    //representa um objeto da realidade que é um cliente
    public class Cliente
    {
        //características do objeto cliente que é rg e nome
        //são propriedades porque são acessados por classes de fora.
        public string rg { get; set; }
        public string nome { get; set; }

        //construtor da classe cliente, exige que quando o objeto seja criado obrigatoriamento ele tem que ter rg e nome
        public Cliente(string rg, string nome)
        {
            //estes atributos da classe de cliente representado pelo this, recebe os valores do construtor
            this.rg = rg;
            this.nome = nome;

            //valida os campos durante a criação do objeto Cliente
            //verifica se o rg, não tem espaço em branco e não é vazio e não é nulo. Verifica se o nome não é vazio e não é nulo.
          //  if (string.IsNullOrEmpty(rg) == false && string.IsNullOrWhiteSpace(rg) == false && string.IsNullOrEmpty(nome) == false)
         //   {
              
         //   }
           
        }
    }
}

