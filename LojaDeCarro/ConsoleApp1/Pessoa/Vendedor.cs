using System;

//namespace utilizado para organização do codigo, pensado no modulo de pessoas
namespace Cappta.LojaDeCarro.Pessoas
{
    //Vendedor é um objeto do sistema, porque ele é um funcionário da concessionária de veículos
  public class Vendedor 
    {
        //um vendedor tem um nome, então nome é uma característica do vendedor
        public string nome { get; set; }

        //construtor da classe vendedor, obrigatoriamente ele tem que ter um nome
        public Vendedor(string nome)
        {
            //valida os campos durante a criação do objeto Vendedor
            //verifica se o nome é nulo ou vazio
            if (string.IsNullOrEmpty(nome))
            {
                Console.Write("o valor é nulo");
                //estes atributos da classe da classe vendedor representado pelo this, recebe os valores recebidos do construtor
                return;
            }
            Console.Write("pegando valores");
            this.nome = nome;  
        }

    }
}
