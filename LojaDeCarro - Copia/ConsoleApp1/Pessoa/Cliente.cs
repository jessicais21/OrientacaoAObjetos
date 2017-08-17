using System;

namespace Cappta.LojaDeCarro.Pessoas
{
    //cliente é um objeto do sistema porque ele representa quem compra o carro da concessionária.
    //representa um cliente da vida real
    public class Cliente
    {
        //características do objeto cliente que é rg e nome
        //são propriedades porque são acessados por classes de fora.
        public string rg { get; set; }
        public string nome { get; set; }

        //construtor da classe cliente, exige que quando o objeto seja criado obrigatoriamento ele tem que ter rg e nome
        public Cliente(string rg, string nome)
        {
            //valida os campos durante a criação do objeto Cliente - importante para a manutenção do codigo
            //verifica se o rg e o nome,  tem espaço em branco ou é vazio ou é nulo.
            //IsNUllOrWhiteSpace - verificar se só tem espaço em branco, nulo e também inclui a verificação de espaço vazio.

            if (string.IsNullOrWhiteSpace(rg))
            {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch

                throw new ArgumentNullException("Dados invalidos do rg cliente");
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dados invalidos para o nome do cliente");
            }



            this.rg = rg;
            this.nome = nome;

        }
    }
}

