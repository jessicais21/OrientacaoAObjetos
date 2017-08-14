using System;

namespace Cappta.LojaDeCarro.Pessoas
{
    //Vendedor é um objeto do sistema, porque representa um vendedor da concessionária de veículos
  public class Vendedor 
    {
        //um vendedor tem um nome, então nome é uma característica do vendedor
        public string nome { get; set; }

        //construtor da classe vendedor, obrigatoriamente ele tem que ter um nome
        public Vendedor(string nomeRecebido)
        {
            //verifica se a string é nula e gera uma exceção
            //isNullOrEmpty - verifica se tem espaço vazio ou nulo
             if (string.IsNullOrWhiteSpace(nomeRecebido))
           {
                //lança uma exceção
                throw new Exception();
             }

            //confirma a criação do objeto com referencia ao atributo
            else
            {
                this.nome = nomeRecebido;
            }

           

           
        }

      
    }
}
