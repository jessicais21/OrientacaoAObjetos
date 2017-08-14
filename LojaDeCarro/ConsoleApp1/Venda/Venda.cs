
//namespace utilizado para organização do codigo, pensado no modulo de estoque
using Cappta.LojaDeCarro.Estoque;
//namespace utilizado para organização do codigo, pensado no modulo de pessoas
using Cappta.LojaDeCarro.Pessoas;
using System;
using System.Windows.Forms;

namespace Cappta.LojaDeCarro.Venda
{
    //objeto venda porque representa uma venda da concessionária
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
        public DateTime dataEHorasDaVenda { get; set; }
        //o codigo da venda é o identificador de cada venda tem as propriedades get e set
        public int numeroDaVenda { get; set; }

        //construtores que exigem os valores no argumento quando o objeto seja instanciado
        //obriga a que quando a venda seja realizada, passe os paramentros que tem dentro do argumento.
        //aplicação do polimorfismo em veiculo, classe carro sendo recebida e construtor utilizando o IVeiculo
        //além do codigo e hora recebe os objetos vendedor, cliente e carro do Form
        public Venda(int identificadorGeradoDaVenda, DateTime dataEhora, Vendedor vendedor, Cliente cliente, IVeiculo veiculo)
        {
            //validação durante a criação do objeto
            //IsNUllOrWhiteSpace - verificar se tem espaço em branco e também inclui a verificação de espaço vazio.
            //isNullOrEmpty - verifica se tem espaço vazio ou nulo
            //verifica se as referencias dos tipos DataEhora, vendedor, cliente e veiculo
            if (identificadorGeradoDaVenda < 0 || dataEhora==null ||vendedor==null 
                ||  cliente==null || veiculo==null){

                //gerou uma exceção, porque o valor digitado pelo usuário não foi de acordo com o esperado
                //a exceção é do tipo ArgumentNullException que é a exceção específica para argumentos
                //o tratamento da exceçao é feito pelo try catch
                throw new ArgumentNullException("dados invalidos para a venda");
            }

            else{
                numeroDaVenda = identificadorGeradoDaVenda;
                dataEHorasDaVenda = dataEhora;             
                this.vendedor = vendedor;               
                this.cliente = cliente;
                this.veiculo = veiculo;
            }
        }
    }
}
