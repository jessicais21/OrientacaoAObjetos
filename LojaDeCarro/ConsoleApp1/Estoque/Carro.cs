//Carro é um objeto porque representa um carro da vida real.
using System;
using System.Windows.Forms;


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
        public Carro(string chassi, string marca, string modelo, string cor,int ano, double valor)
        {
            //valida os campos durante a criação do objeto Carro
            //verifica se o chassi, marca, modelo, cor, ano e valor, não tem espaço em branco e não é vazio e não é nulo
            //ano maior que 1990 porque a empresa existe mais de 20 anos e os carros registrados é a partir do ano de 1990
            //os valores dos carros é a partir de 1000 reais, por causa dos valores registrados
            if ( string.IsNullOrWhiteSpace(chassi)  || string.IsNullOrWhiteSpace(marca)
                  ||  string.IsNullOrWhiteSpace(modelo)   || string.IsNullOrWhiteSpace(cor) || ano < 1990 || valor < 1000 )
              {
                //lança uma exceção 
                throw new Exception();
            }

            else
            {//estes atributos da classe carro representado pelo this, recebe os valores do construtor
                this.chassi = chassi;
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
                this.ano = ano;
                this.valor = valor;
            }

        }

    }
}
