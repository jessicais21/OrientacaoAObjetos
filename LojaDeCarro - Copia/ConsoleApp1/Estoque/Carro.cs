
using System;


namespace Cappta.LojaDeCarro.Estoque
{
    //representa o objeto Carro , assina com a interface IVeiculo
    // //Carro é um objeto porque representa um carro da vida real.
    public class Carro : IVeiculo
    {
        //que tem as características de chassi,marca,modelo, cor, ano e valor
        //utiliza as propriedades get e set
        public string chassi { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public double valor { get; set; }

        //construtor da classe carro, que exige que quando o objeto seja criado seja enviado alguns valores.
        //valores 
        public Carro(string chassi, string marca, string modelo, string cor,int ano, double valor)
        {
            //valida os campos durante a criação do objeto Carro
            //verifica se o chassi, marca, modelo, cor, ano e valor,  tem espaço em branco ou  é vazio ou é nulo
           
            if (string.IsNullOrWhiteSpace(chassi)) {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dados invalidos para o chassi do carro");
            }

            if (string.IsNullOrWhiteSpace(marca)) {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dados invalidos para a marca do carro");
            }


            if (string.IsNullOrWhiteSpace(modelo)) {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dados invalidos para o modelo do carro");
            }

            if (string.IsNullOrWhiteSpace(cor)) {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dados invalidos para a cor do carro");

            }

            if (ano == default(int))
            {
                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("Dados invalidos para o carro");
            }

            //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
            //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
            //o tratamento da exceçao é feito pelo try catch
            if (valor == default(double))
            {
                throw new ArgumentNullException("Dados invalidos para o valor do carro");
            }

            
                this.chassi = chassi;
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
                this.ano = ano;
                this.valor = valor;
      
        }

    }
}
