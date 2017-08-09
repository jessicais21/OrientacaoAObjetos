
using Cappta.LojaDeCarro.Estoque;
using Cappta.LojaDeCarro.Pessoas;
using System;

namespace Cappta.LojaDeCarro.Venda
{
public class Venda
    {
        public Cliente cliente;
        public Vendedor vendedor;
        public IVeiculo veiculo;
        public DateTime dataEHora;
        public int codigo;

        //construtores que exigem quando o objeto seja instanciado
        //obriga a que quando a venda seja realizada, passe os paramentros que tem dentro do argumento.
        //aplicação do polimorfismo em veiculo, classe carro sendo recebida e construtor utilizando o IVeiculo
       
        public Venda(int codigo, DateTime dataEhora, Vendedor vendedor, Cliente cliente, IVeiculo veiculo)
        {

            this.codigo = codigo;
            this.dataEHora = dataEhora;
            this.veiculo = veiculo;
            this.cliente = cliente;
            this.vendedor = vendedor;

        }
    }
}
