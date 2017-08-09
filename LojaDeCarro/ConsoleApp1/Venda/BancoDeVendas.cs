using System;
using System.Collections.Generic;
using System.IO;
using Cappta.LojaDeCarro.Estoque;
using Cappta.LojaDeCarro.Pessoas;

namespace Cappta.LojaDeCarro.Venda
{
    public class BancoDeVendas
    {
        public List<Venda> listaDeVenda { get; set; } = new List<Venda>();

        //somente para visualização do arquivo
        private string arquivoDeVendas = "vendas.txt";

        public BancoDeVendas()
        {
            PreencherListaDeVendas();
        }

        public void PreencherListaDeVendas()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco mesmo quando uma exceção é lançada pelo código.
            using (var arquivo = new StreamReader(arquivoDeVendas))
            {
                String line;

                while ((line = arquivo.ReadLine()) != null)
                {
                    //verifica se a string é nula ou vazia, sai da função
                    if (string.IsNullOrEmpty(line))
                    {
                        //finaliza a execução do método 
                        return;
                    }

                    string[] quebra = line.Split(',');

                    var identificadorDaVenda = Int32.Parse(quebra[0]);
                    var dataDaVenda = Convert.ToDateTime(quebra[1]);

                    var nomeDoVendedor = quebra[2];

                    var rg = quebra[3];
                    var nomeDoCliente = quebra[4];

                    var chassi = quebra[5];
                    var marcaDoCarro = quebra[6];
                    var modeloDoCarro = quebra[7];
                    var cor = quebra[8];
                    var anoDoCarro = Int32.Parse(quebra[9]);
                    var valorDoCarro = Convert.ToDouble(quebra[10]);

                    Vendedor vendedor = new Vendedor(nomeDoVendedor);

                    Carro carro = new Carro(chassi, marcaDoCarro, modeloDoCarro, cor, anoDoCarro, valorDoCarro);
                 
                    Cliente cliente = new Cliente(rg, nomeDoCliente);
                 
                    Venda venda = new Venda(identificadorDaVenda, dataDaVenda, vendedor, cliente, carro);

                    listaDeVenda.Add(venda);

                }
            }

        }

        public void Atualizar()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco mesmo quando uma exceção é lançada pelo código.
            using (var arquivo = new StreamWriter(arquivoDeVendas))
            {
                //percorre o conjunto de dados e passar um por um
                foreach (var listarVendas in this.listaDeVenda)
                {
                    arquivo.WriteLine(listarVendas.codigo + "," + listarVendas.dataEHora+ ',' +listarVendas.vendedor.nome + "," + listarVendas.cliente.rg + "," + listarVendas.cliente.nome + ","
                                     + listarVendas.veiculo.chassi + "," + listarVendas.veiculo.marca + "," + listarVendas.veiculo.modelo + ","+listarVendas.veiculo.cor+
                                     "," + listarVendas.veiculo.ano + "," + listarVendas.veiculo.valor);
                }
            }

        }
       
    }
}
