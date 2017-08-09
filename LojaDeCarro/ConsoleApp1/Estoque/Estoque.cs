using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cappta.LojaDeCarro.Estoque
{

    //É o gerenciamento de produtos, no caso da concessionária é o gerenciamento de carros

    public class Estoque
    {
        //cria uma lista de objeto carro
        public List<Carro> listaDeCarro { get; set; } = new List<Carro>();
      
        //private para ser visualizado somente nessa classe porque eu não quero permitir que as outras classes visualize este atributo
        //representa o local de armazenamento do carro no sistema
        private string arquivoDoEstoque = "carro.txt";
   
        //quando é criado o objeto Estoque é chamada a função PreencherListaDeCarro
        public Estoque()
        { //a função é responsável por preencher o estoque de carros
            PreencherListaDeCarro();
        }

        //é responsável por preencher o estoque de carros
        public void PreencherListaDeCarro()
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
        public void AlterarListaDeCarro()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco 
            using (var arquivo = new StreamWriter(arquivoDoEstoque))
            {
                foreach (var listarCarros in this.listaDeCarro)
                {
                    arquivo.WriteLine(listarCarros.chassi + "," + listarCarros.marca + "," + listarCarros.modelo + ","+listarCarros.cor+"," + listarCarros.ano + "," + listarCarros.valor);
                }
            }
        }

        //retorna todos os carro para o usuário
        public List<Carro> PegarListaDeCarro()
        {
            return listaDeCarro;
        }

        //adiciona os carros no estoque e altera o estoque de carros 
        public void AdicionarCarrosNoEstoque(Carro carro)
        {
            //adiciona um carrro no estoque
            listaDeCarro.Add(carro);
            //altera o estoque de carros
            AlterarListaDeCarro();
        }

        //conta os carros armazenados no estoque de acordo com o critério de busca 
        public int QuantidadeDeCarro(string marca, string modelo, int ano)
        {
            //LINQ sendo utilizado para contar os elementos de acordo com a busca
            int quantidade = listaDeCarro.Count(carro => carro.marca.Equals(marca) && carro.modelo.Equals(modelo) && carro.ano.Equals(ano));

            return quantidade;
        }


        //verifica se o carro existe no estoque
        public bool VerificarAsInformaçoesDoCarro(Carro carro)
        {
            //método que verifica na lista de carros e retorna se encontrou o carro, utiliza o método Exists
            bool verificarCarro = listaDeCarro.Exists(carros => carros.chassi.Equals(carro.chassi) && carros.marca.Equals(carro.marca) && carros.modelo.Equals(carro.modelo) &&
                                                               carros.cor.Equals(carro.cor) && carros.ano.Equals(carro.ano) && carros.valor.Equals(carro.valor));

            return verificarCarro;
        }

        //remove algum carro no estoque e atualiza o estoque
        public void AtualizarNaListaDeCarros(Carro carro)
        {
            //retorna o primeiro elemento encontrado correspondente ao objeto carro.
            //utilização da biblioteca LINQ para fazer a busca do carro através do Where
            //First para buscar somente o primeiro e unico elemento
            var carroParaRemover = listaDeCarro.Where(carros => carros.chassi.Equals(carro.chassi) && carros.marca.Equals(carro.marca) && carros.modelo.Equals(carro.modelo) &&
                      carros.cor.Equals(carro.cor) && carros.ano.Equals(carro.ano) && carros.valor.Equals(carro.valor)).First();
            //remove o carro no estoque
            listaDeCarro.Remove(carroParaRemover);
            //altera o estoque de carros
            AlterarListaDeCarro();

        }

        //faz a busca no estoque de carros de acordo com a marca que foi inputada pelo usuário 
        public List<Carro> PesquisarPelaMarca(string marca)
        {
            //procura no estoque os carros que possui o critério de busca inputada pelo usuário
            //utiliza o metodo o Collection FindAll que procura todas as marcas de carro de acordo com o critério de busca
            //armazenar todos os resultados em uma lista
            List<Carro> listaDeCarroDaBuscaPorMarca = listaDeCarro.FindAll(carro => carro.marca.Equals(marca));

            return listaDeCarroDaBuscaPorMarca;
        }

        //faz a busca no estoque de carros de acordo com o modelo que foi inputado pelo usuário
        public List<Carro> PesquisarPeloModelo(string modelo)
        {
            //procura no estoque os carros que possui o critério de busca inputada pelo usuário
            //utiliza o metodo o Collection FindAll que procura todos os modelos de carro de acordo com o critério de busca
            //armazenar todos os resultados em uma lista
            List<Carro> listaDeCarroDaBuscaPorModelo = listaDeCarro.FindAll(carro => carro.modelo.Equals(modelo));

            return listaDeCarroDaBuscaPorModelo;
        }

        //faz a busca no estoque de carros de acordo com a cor que foi inputado pelo usuário
        public List<Carro> PesquisarPelaCor(string cor)
        {
            //procura no estoque os carros que possui o critério de busca inputada pelo usuário
            //utiliza o metodo o Collection FindAll que procura todas as cores de carro de acordo com o critério de busca
            //armazenar todos os resultados em uma lista
            List<Carro> listaDeCarroPelaCor = listaDeCarro.FindAll(carro => carro.cor.Equals(cor));

            return listaDeCarroPelaCor;
        }

    }

}
