using System;
using System.Windows.Forms;

namespace Cappta.LojaDeCarro.Pessoas
{
    //Vendedor é um objeto do sistema, porque representa um vendedor da concessionária de veículos
  public class Vendedor 
    {
        //um vendedor tem um nome, então nome é uma característica do vendedor
        public string nome { get; set; }

        //construtor da classe vendedor, obrigatoriamente ele tem que ter um nome
        public  Vendedor(string nomeRecebido)
        {
           
            //verifica se a string é nula e gera uma exceção
            //isNullOrEmpty - verifica se tem espaço vazio ou nulo  ou preenchido somente com espaço
             if (string.IsNullOrWhiteSpace(nomeRecebido))
             {
               //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
               //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
               //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dado invalido para o vendedor");
            
            }

            //confirma a criação do objeto com referencia ao atributo
            else
            {
                this.nome = nomeRecebido;
              
            }

           

           
        }

      
    }
}
