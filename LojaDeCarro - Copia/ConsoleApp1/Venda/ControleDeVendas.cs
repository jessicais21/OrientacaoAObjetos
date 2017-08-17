//coleção de um mesmo tipo de dado
using System.Collections.Generic;
//utiliza as classes pertencentes ao namespace Cappta.LojaDeCarro.Pessoas
using Cappta.LojaDeCarro.Pessoas;
//utiliza as classes pertencentes ao namespace Cappta.LojaDeCarro.Estoque
using Cappta.LojaDeCarro.Estoque;
//responsável pela utilização das funções do LINQ
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
            using (var arquivo = new StreamReader(arquivoDeVendas))
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

                       //cria o objeto vendedor com as características, porque representa um vendedor da vida real
                        Vendedor vendedor = new Vendedor(nomeDoVendedor);

                        //cria o objeto cliente com as características, representa um cliente na vida real
                        Cliente cliente = new Cliente(rg, nomeDoCliente);

                        //cria o objeto carro com as características, porque representa um carro na vida real
                        Carro carro = new Carro(chassi, marcaDoCarro, modeloDoCarro, cor, anoDoCarro, valorDoCarro);

                        //cria o objeto venda com as características que utiliza os objetos vendedor, carro e cliente
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
            using (var arquivo = new StreamWriter(arquivoDeVendas))
            {
                //percorre o conjunto de dados e passar um por um
                //recebe a lista de venda atualizadas e escreve no arquivo
                foreach (var listarVendas in this.listaDeVenda)
                {
                    arquivo.WriteLine(listarVendas.numeroDaVenda + "," + listarVendas.dataEHorasDaVenda + ',' + listarVendas.vendedor.nome + "," + listarVendas.cliente.rg + "," + listarVendas.cliente.nome + ","
                                     + listarVendas.veiculo.chassi + "," + listarVendas.veiculo.marca + "," + listarVendas.veiculo.modelo + "," + listarVendas.veiculo.cor +
                                     "," + listarVendas.veiculo.ano + "," + listarVendas.veiculo.valor);
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
        public string VerificarDadosParaEfetuarVenda (Vendedor vendedor, Cliente cliente, Carro carro)
        {
           
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
                //representa o objeto da vida real venda
               
                    Venda venda = new Venda(Numeroidentificador, localDate, vendedor, cliente, carro);
                    AdicionarVendas(venda);

                return "venda efetuada com sucesso";

            }

            else
            {
                return "não foram confirmados os dados para efetuar a venda";
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
            var ultimoRegistroDoCodigo = listaDeVenda.OrderByDescending(venda => venda.numeroDaVenda).First();

            //gera o identificador e adiciona mais um no ultimo codigo da venda
            int gerarIdentificador = ultimoRegistroDoCodigo.numeroDaVenda + 1;

            return gerarIdentificador;
        }

        //verifica se existe no sistema  as informações do objeto venda inseridas pelo vendedor 
        //retorna se é valida ou não as informações do objeto venda
        public string VerificarDadosParaOCancelamentoDeVenda(Cliente cliente, Carro carro)
        {
            //método que verifica na lista de vendas e retorna se encontrou a venda, utiliza o método Exists
            //utiliza a função anônima para comparar cada venda pertencente a lista de vendas de acordo com o critério de busca recebido do objeto carro e cliente
            bool verificarVenda = listaDeVenda.Exists(venda => venda.cliente.rg.Equals(cliente.rg) && venda.cliente.nome.Equals(cliente.nome)
                    && venda.veiculo.chassi.Equals(carro.chassi) &&
                    venda.veiculo.marca.Equals(carro.marca) && venda.veiculo.modelo.Equals(carro.modelo) &&
                    venda.veiculo.cor.Equals(carro.cor) && venda.veiculo.ano.Equals(carro.ano) &&
                    venda.veiculo.valor.Equals(carro.valor));


            if (verificarVenda)
            {
                CancelamentoDeVenda(cliente, carro);
                //adiciona no estoque de carros que é o objeto responsável por controlar os carros
                EstoqueDeCarro estoque = new EstoqueDeCarro();
                estoque.AdicionarCarros(carro);
                return "cancelamento efetuado com sucesso";
            }

            else
            {
                return "não foram encontrados os dados para o cancelamento";
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
            var removerAVenda = listaDeVenda.Where(venda => venda.cliente.rg.Equals(cliente.rg) && venda.cliente.nome.Equals(cliente.nome) &&
                    venda.veiculo.chassi.Equals(carro.chassi) &&
                    venda.veiculo.marca.Equals(carro.marca) && venda.veiculo.modelo.Equals(carro.modelo) &&
                    venda.veiculo.cor.Equals(carro.cor) && venda.veiculo.ano.Equals(carro.ano) &&
                    venda.veiculo.valor.Equals(carro.valor)).First();

            //remove uma venda na lista de vendas
            listaDeVenda.Remove(removerAVenda);

            //altera arquivo de vendas
            AlterarArquivoDeVendas();

        }

        //faz a busca da venda de acordo com a data ou hora que foi inputado pelo vendedor
        public List<Venda> BuscarPorDataOuHora(string dataOuHora)
        {
            //procura na lista de vendas que possui o critério de busca inputada pelo vendedor 
            //converte o atributo data para string e pergunta se nessa string contem a data buscada e armazena em uma lista
            //armazena todos os elementos da lista de busca de venda baseado na busca por data ou hora através do FindAll
            //armazenar todos os resultados em uma lista
            //utiliza a função anônima para comparar cada venda pertencente a lista de vendas 
            // de acordo com o critério de busca recebido por data ou hora
       
                List<Venda> listaDeBuscaDeVendas = listaDeVenda.FindAll(vendas => vendas.dataEHorasDaVenda.ToString().Contains(dataOuHora));
                return listaDeBuscaDeVendas;
      
        }
    }

}
