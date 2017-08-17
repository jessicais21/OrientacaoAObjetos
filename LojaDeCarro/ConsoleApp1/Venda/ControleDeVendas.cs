
using System.Collections.Generic;

using Cappta.LojaDeCarro.Pessoas;
using System.Windows.Forms;
using Cappta.LojaDeCarro.Estoque;

using System.Linq;
using System.IO;
using System;

namespace Cappta.LojaDeCarro.Venda
{

    //É o controle de vendas, é responsável por adicionar e cancelar vendas
    public class ControleDeVendas
    {
        //cria uma lista de objeto venda
        //utilizando a propriedade get e set - porque estou alterando a lista de objetos de Venda durante a classe 
        //permite que a lista de vendas seja visualizada no Form
        public List<Venda> listaDeVenda { get; set; } = new List<Venda>();

        //private para ser visualizado somente nessa classe porque eu não quero permitir que as outras classes visualize este atributo
        //representa o local de armazenamento da venda no sistema
        private string arquivoDeVendas = "vendas.txt";

        //construtor vazio da classe Venda, ele é chamado quando é criado o objeto Venda
        // o construtor chama a função PreencherListaDeVendas
        public ControleDeVendas()
        {//a função é responsável por preencher a lista de vendas
                PreencherListaDeVendas();
        }

        //é responsável por preencher a lista de vendas
        //pega os dados que estão armazenados no arquivo e preenche na lista de vendas
        public void PreencherListaDeVendas()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco mesmo quando uma exceção é lançada pelo código.
            using (StreamReader arquivo = new StreamReader(arquivoDeVendas))
            {
                string line;

                //ler até o final da linha no arquivo
                while ((line = arquivo.ReadLine()) != null)
                {
                    //verifica se a string é nula ou vazia, sai da função
                    if (string.IsNullOrEmpty(line))
                    {
                        //finaliza a execução do método 
                        return;
                    }

                    string[] quebra = line.Split(',');

                    int identificadorDaVenda = Int32.Parse(quebra[0]);
                    DateTime dataDaVenda = Convert.ToDateTime(quebra[1]);

                    string nomeDoVendedor = quebra[2];

                    string rg = quebra[3];
                    string nomeDoCliente = quebra[4];

                    string chassi = quebra[5];
                    string marcaDoCarro = quebra[6];
                    string modeloDoCarro = quebra[7];
                    string cor = quebra[8];
                    int anoDoCarro = Int32.Parse(quebra[9]);
                    double valorDoCarro = Convert.ToDouble(quebra[10]);

                      
                        Vendedor vendedor = new Vendedor(nomeDoVendedor);

                     
                        Cliente cliente = new Cliente(rg, nomeDoCliente);

                       
                        Carro carro = new Carro(chassi, marcaDoCarro, modeloDoCarro, cor, anoDoCarro, valorDoCarro);

                      
                        Venda venda = new Venda(identificadorDaVenda, dataDaVenda, vendedor, cliente, carro);

                        listaDeVenda.Add(venda);
                   
                }
            }

        }

        //altera o arquivo de venda     
        public void AlterarArquivoDeVendas()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco mesmo quando uma exceção é lançada pelo código.
            //var é o tipo StreamWriter, pois o seu tipo é criado posteriormente ao sinal =
            using (StreamWriter arquivo = new StreamWriter(arquivoDeVendas))
            {
                //percorre o conjunto de dados e passar um por um
                //recebe a lista de venda atualizadas e escreve no arquivo
                foreach (Venda listarVendas in listaDeVenda)
                {
                
                    //formatar uma cadeira de caracteres e coloca em uma string
                    string escreverNoArquivoDeVenda = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", listarVendas.numeroDaVenda,listarVendas.dataEHorasDaVenda, listarVendas.vendedor.nome, 
                                                                    listarVendas.cliente.rg,listarVendas.cliente.nome, listarVendas.veiculo.chassi,listarVendas.veiculo.marca,listarVendas.veiculo.modelo,
                                                                    listarVendas.veiculo.cor,listarVendas.veiculo.ano,listarVendas.veiculo.valor);
                    arquivo.WriteLine(escreverNoArquivoDeVenda);
                }
            }

        }
        
        //adiciona as vendas no controle de venda
        public void AdicionarVendas(Venda venda)
        {
            //adiciona uma venda na lista
            listaDeVenda.Add(venda);
            //altera o arquivo de venda
            AlterarArquivoDeVendas();
        }

        //verificar dados para efetuar a venda da venda
        public string EfetuarVenda (Vendedor vendedor, Cliente cliente, Carro carro)
        {
            string retornar = "";  
            //cria do objeto estoque de carro, responsável por fazer o controle de carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            //verifica se o carro existe no estoque
            bool checarInformacoesDoCarro = estoque.VerificarSeOCarroExisteNoEstoque(carro);

            if (checarInformacoesDoCarro)
            {
                DateTime localDate = DateTime.Now;
                //remove o carro do estoque.
                estoque.RemoverCarros(carro);
                //gera o numero identificador para criação da venda
                int Numeroidentificador = GerarIdentificadorDaVenda();
                
               
                    Venda venda = new Venda(Numeroidentificador, localDate, vendedor, cliente, carro);
                    AdicionarVendas(venda);

                retornar = "venda efetuada com sucesso";
                return retornar;

            }

            else
            {
                retornar = "não foram confirmados os dados para efetuar a venda";
                return retornar;
            }
          
        }

        //gera o identificador da proxima venda, para a criação do objeto venda
        //retorna um tipo inteiro
        public int GerarIdentificadorDaVenda()
        {
            //ordena a lista de venda para ser descendente de acordo com o codigo da lista de objetos e coloca o ultima venda como primeira
            //utilizacao do OrderByDescending do LINQ, então ele pega a ordem descendente de um determinado campo
            //utiliza o Lambda para detectar o ultimo codigo da lista de vendas
            //pega o ultimo elemento da lista e coloca como primeiro
            Venda ultimoRegistroDoCodigo = listaDeVenda.OrderByDescending(venda => venda.numeroDaVenda).First();

            //gera o identificador e adiciona mais um no ultimo codigo da venda
            int gerarIdentificador = ultimoRegistroDoCodigo.numeroDaVenda + 1;

            return gerarIdentificador;
        }

        //verifica se existe no sistema  as informações do objeto venda inseridas pelo vendedor 
        //retorna se é valida ou não as informações do objeto venda
        public string VerificarDadosParaOCancelamentoDeVenda(Cliente cliente, Carro carro)
        {
            string retornarCancelamentoDeVenda = "";

            //método que verifica na lista de vendas e retorna se encontrou a venda, utiliza o método Exists
            //utiliza a função anônima para comparar cada venda pertencente a lista de vendas de acordo com o critério de busca recebido do objeto carro e cliente
            bool verificarVenda = listaDeVenda.Exists(venda => venda.cliente.rg.Equals(cliente.rg)  && venda.veiculo.chassi.Equals(carro.chassi));


            if (verificarVenda)
            {
                CancelamentoDeVenda(cliente, carro);
                //adiciona no estoque de carros que é o objeto responsável por controlar os carros
                EstoqueDeCarro estoque = new EstoqueDeCarro();
                estoque.AdicionarCarros(carro);
                retornarCancelamentoDeVenda = "cancelamento efetuado com sucesso";
                return retornarCancelamentoDeVenda;
            }

            else
            {
             
                retornarCancelamentoDeVenda = "não foram encontrados os dados para o cancelamento";
                return retornarCancelamentoDeVenda;
            }

          
        }

        //faz o cancelamento de uma venda de acordo com o cliente e carro inputados pelo vendedor
        public void CancelamentoDeVenda(Cliente cliente, Carro carro)
        {
            //retorna o primeiro elemento encontrado correspondente ao objeto vendas.
            //utilização da biblioteca LINQ para fazer a busca do vendas através do Where
            //First para buscar somente o primeiro e unico elemento
            //utiliza a função anônima para comparar cada carro pertencente a lista de vendas 
            // de acordo com o critério de busca recebido do objeto vendas
            Venda removerAVenda = listaDeVenda.Where(venda => venda.cliente.rg.Equals(cliente.rg) &&
                    venda.veiculo.chassi.Equals(carro.chassi)).First();

            //remove uma venda na lista de vendas
            listaDeVenda.Remove(removerAVenda);

            //altera arquivo de vendas
            AlterarArquivoDeVendas();

        }

        

        public List<Venda> BuscarPorRg(string Rg)
        {
            //procura na lista de vendas que possui o critério de busca inputada pelo vendedor 
            //converte o atributo data para string e pergunta se nessa string contem a data buscada e armazena em uma lista
            //armazena todos os elementos da lista de busca de venda baseado na busca por rg através do FindAll
            //armazenar todos os resultados em uma lista
            //utiliza a função anônima para comparar cada venda pertencente a lista de vendas 
            // de acordo com o critério de busca recebido pelo rg
            List<Venda> listaDeBuscaDeVendas = listaDeVenda.FindAll(vendas => vendas.cliente.rg.Equals(Rg));
            return listaDeBuscaDeVendas;
        }


        public List<Venda> BuscarNoIntervaloDeData(string dataInicio, string dataFim)
        {
            //converte string para data para o inicio da busca
            DateTime dataInicioBusca = DateTime.Parse(dataInicio);
           
            //hora sendo criada por Default : 00:00:00, a data final tem que pegar ate o ultimo minuto do dia
            string horaFinalDaDataDaBusca = "23:59:59";

            //concatena a string
            string concatenandoDataFim = dataFim+" "+horaFinalDaDataDaBusca;
           
            //converter para o dateTime para a realização de busca
            DateTime dataFimBusca = Convert.ToDateTime(concatenandoDataFim);

            //procura todos da pertencentes a lista do DateTime, e lista todas as vendas de acordo com a data de inicio e fim digitada pelo usuario
            List<Venda> listaDeBuscaDeVendas = listaDeVenda.FindAll(listasVendas => listasVendas.dataEHorasDaVenda >= dataInicioBusca && listasVendas.dataEHorasDaVenda <= dataFimBusca);
          
            return listaDeBuscaDeVendas;
        }

    }

}
