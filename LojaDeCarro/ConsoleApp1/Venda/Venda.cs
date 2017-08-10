
//namespace utilizado para organização do codigo, pensado no modulo de estoque
using Cappta.LojaDeCarro.Estoque;
//namespace utilizado para organização do codigo, pensado no modulo de pessoas
using Cappta.LojaDeCarro.Pessoas;
using System;

//namespace utilizado para organização do codigo, pensado no modulo de venda
namespace Cappta.LojaDeCarro.Venda
{
    //objeto venda que representa a realidade de uma venda
public class Venda
    {
        //características da venda é ter codigo, data e hora, vendedor , cliente e veiculo

        //variável do tipo Cliente que tem as propriedades get e set
        public Cliente cliente { get; set; }
        //variável do tipo Vendedor que tem as propriedades get e set
        public Vendedor vendedor { get; set; }
        //variável do tipo IVeículo que tem as propriedades get e set
        public IVeiculo veiculo { get; set; }
        //classe DateTime responsável pela data 
        public DateTime dataEHoras { get; set; }
        //o codigo da venda é o identificador de cada venda tem as propriedades get e set
        public int codigo { get; set; }

        //construtores que exigem os valores no argumento quando o objeto seja instanciado
        //obriga a que quando a venda seja realizada, passe os paramentros que tem dentro do argumento.
        //aplicação do polimorfismo em veiculo, classe carro sendo recebida e construtor utilizando o IVeiculo
        //além do codigo e hora recebe os objetos vendedor, cliente e carro do Form
        public Venda(int codigo, DateTime dataEhora, Vendedor vendedor, Cliente cliente, IVeiculo veiculo)
        {
          //o codigo e o data é gerado automaticamente pelo sistema por isso que não precisa de verificação
          //quando é recebido os objetos vendedor, cliente e veiculo eles já passaram pela verificação ao serem instanciados
                this.codigo = codigo;
                this.dataEHoras = dataEhora;
                this.veiculo = veiculo;
                this.cliente = cliente;
                this.vendedor = vendedor;
          
           

        }
    }
}
