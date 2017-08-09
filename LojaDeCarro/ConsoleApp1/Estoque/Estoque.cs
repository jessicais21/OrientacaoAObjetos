using System;
//responsável pela utilização do Collections
using System.Collections.Generic;
using System.IO;
//responsável pela utilização das funções do LINQ
using System.Linq;

namespace Cappta.LojaDeCarro.Estoque
{

    //É o controle de produtos, no caso da concessionária é o gerenciamento de carros
    //O controle de carros é responsável por adicionar e remover carros do estoque
    //Para a alteração dos carros no estoque no sistema é utilizado o arquivo 
    public class Estoque
    {
        //cria uma lista de objeto carro
        //utilizando a propriedade get e set
        //somente permite a escrita da lista na própria classe estoque - atributo set
        //permite que a lista seja visualizada pela classe na classe de usuário
        public List<Carro> listaDeCarro { get; private set; } = new List<Carro>();
      
        //private para ser visualizado somente nessa classe porque eu não quero permitir que as outras classes visualize este atributo
        //representa o local de armazenamento do carro no sistema
        private string arquivoDoEstoque = "carro.txt";

        //construtor vazio da classe Estoque, ele é chamado quando é criado o objeto Estoque
        // o construtor chama a função PreencherListaDeCarro 
        public Estoque()
        { //a função é responsável por preencher o estoque de carros
            PreencherListaEstoqueDeCarro();
        }

        //é responsável por preencher a lista de carros que estão no estoque 
        //pega os dados que estão armazenados no arquivo e preenche na lista de carros
        public void PreencherListaEstoqueDeCarro()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco 
            using (var arquivo = new StreamReader(arquivoDoEstoque))
            {
                string line;

                //ler até o final da linha no arquivo
                while ((line = arquivo.ReadLine()) != null)
                {
                    //verifica se a string da linha é nula ou vazia, sai da função
                    if (string.IsNullOrEmpty(line))
                    {
                        //sair da função
                        return;
                    }

                    string[] quebra = line.Split(',');
                    var identificador = quebra[0];
                    var marca = quebra[1];
                    var modelo = quebra[2];
                    var cor = quebra[3];
                    var ano = Int32.Parse(quebra[4]);
                    var valor = Convert.ToDouble(quebra[5]);

                    //cria o objeto carro com as características
                    Carro carro = new Carro(identificador, marca, modelo, cor,ano, valor);
                    // armazena o objeto carro na lista de objeto carro
                    listaDeCarro.Add(carro);
                }
            }
        }


        //altera o estoque de carros
        //recebe a lista de carros atualizadas e escreve no arquivo
        public void AlterarArquivoCarro()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco
            //var é o tipo StreamWriter, pois o seu tipo é criado posteriormente ao sinal =
            using (var arquivo = new StreamWriter(arquivoDoEstoque))
            {
                //escreve cada elemento da lista de carros no arquivo 
                foreach (var listarCarros in this.listaDeCarro)
                {
                    arquivo.WriteLine(listarCarros.chassi + "," + listarCarros.marca + "," + listarCarros.modelo + ","+listarCarros.cor+"," + listarCarros.ano + "," + listarCarros.valor);
                }
            }
        }

        //retorna todos os carro para o usuário
        //esta função retorna todos os elementos da lista de carros, sem critério de busca
        public List<Carro> PegarListaDeCarro()
        {
            return listaDeCarro;
        }

        //função que adiciona os carros no estoque
        public void AdicionarCarros(Carro carro)
        {
            //adiciona um carro na lista
            listaDeCarro.Add(carro);
            //altera o arquivo de estoque de carros
            AlterarArquivoCarro();
        }

        //conta os carros armazenados no estoque de acordo com o critério de busca de marca, modelo e ano
        public int QuantidadeDeCarro(string marca, string modelo, int ano)
        {
            //LINQ sendo utilizado para contar os elementos de acordo com a busca - COUNT
            //utiliza a função anônima para comparar cada carro pertencente a lista de carros 
            // de acordo com o critério de busca de marca, modelo e ano  
            int quantidade = listaDeCarro.Count(carro => carro.marca.Equals(marca) && carro.modelo.Equals(modelo) && carro.ano.Equals(ano));

            return quantidade;
        }


        //verifica se as informações do objeto carro inseridas pelo usuário está existe no sistema 
        //retorna se é valida ou não as informações do objeto carro
        public bool VerificarAsInformaçoesDoCarro(Carro carro)
        {
            //método que verifica na lista de carros e retorna se encontrou o carro, utiliza o método Exists
            //utiliza a função anônima para comparar cada carro pertencente a lista de carros 
            // de acordo com o critério de busca recebido do objeto carro
            bool verificarCarro = listaDeCarro.Exists(carros => carros.chassi.Equals(carro.chassi) && carros.marca.Equals(carro.marca) && carros.modelo.Equals(carro.modelo) &&
                                                               carros.cor.Equals(carro.cor) && carros.ano.Equals(carro.ano) && carros.valor.Equals(carro.valor));

            return verificarCarro;
        }

        //remove carros
        public void RemoverCarros(Carro carro)
        {
            //retorna o primeiro elemento encontrado correspondente ao objeto carro.
            //utilização da biblioteca LINQ para fazer a busca do carro através do Where
            //First para buscar somente o primeiro e unico elemento
            //utiliza a função anônima para comparar cada carro pertencente a lista de carros 
            // de acordo com o critério de busca recebido do objeto carro
            var carroParaRemover = listaDeCarro.Where(carros => carros.chassi.Equals(carro.chassi) && carros.marca.Equals(carro.marca) && carros.modelo.Equals(carro.modelo) &&
                      carros.cor.Equals(carro.cor) && carros.ano.Equals(carro.ano) && carros.valor.Equals(carro.valor)).First();
            //remove o carro na lista
            listaDeCarro.Remove(carroParaRemover);
            //altera o arquivo de estoque de carros
            AlterarArquivoCarro();

        }

        //faz a busca no estoque de carros de acordo com a marca que foi inputada pelo usuário 
        public List<Carro> PesquisarPelaMarcaDeCarros(string marca)
        {
            //procura no estoque os carros que possui o critério de busca inputada pelo usuário
            //utiliza o metodo o Collection FindAll que procura todas as marcas de carro de acordo com o critério de busca
            //armazenar todos os resultados em uma lista
            //utiliza a função anônima para comparar cada carro pertencente a lista de carros 
            // de acordo com o critério de busca recebido do objeto carro
            List<Carro> listaDeCarroDaBuscaPorMarca = listaDeCarro.FindAll(carro => carro.marca.Equals(marca));

            return listaDeCarroDaBuscaPorMarca;
        }

        //faz a busca no estoque de carros de acordo com o modelo que foi inputado pelo usuário
        public List<Carro> PesquisarPeloModeloDeCarros(string modelo)
        {
            //procura no estoque os carros que possui o critério de busca inputada pelo usuário
            //utiliza o metodo o Collection FindAll que procura todos os modelos de carro de acordo com o critério de busca
            //armazenar todos os resultados em uma lista
            //utiliza a função anônima para comparar cada carro pertencente a lista de carros 
            // de acordo com o critério de busca recebido do objeto carro
            List<Carro> listaDeCarroDaBuscaPorModelo = listaDeCarro.FindAll(carro => carro.modelo.Equals(modelo));

            return listaDeCarroDaBuscaPorModelo;
        }

        //faz a busca no estoque de carros de acordo com a cor que foi inputado pelo usuário
        public List<Carro> PesquisarPelaCorDeCarros(string cor)
        {
            //procura no estoque os carros que possui o critério de busca inputada pelo usuário
            //utiliza o metodo o Collection FindAll que procura todas as cores de carro de acordo com o critério de busca
            //armazenar todos os resultados em uma lista
            //utiliza a função anônima para comparar cada carro pertencente a lista de carros 
            // de acordo com o critério de busca recebido do objeto carro
            List<Carro> listaDeCarroPelaCor = listaDeCarro.FindAll(carro => carro.cor.Equals(cor));

            return listaDeCarroPelaCor;
        }

    }

}
