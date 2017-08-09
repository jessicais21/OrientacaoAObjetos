using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cappta.LojaDeCarro.Estoque
{
    //classe criada para armazenar o objeto Estoque com seus comportamentos
   public class Estoque
    {
        //cria a lista de objeto carro
        public List<Carro> listaDeCarro { get; set; } = new List<Carro>();

        //somente para visualização do arquivo
        //private para ser visualizado somente nessa classe porque eu não quero permitir que as outras classes visualize este atributo
        private string arquivoDoEstoque = "carro.txt";
   
        //quando é instanciado o objeto é chamada a função PreencherListaDeCarro
        public Estoque()
        {
            PreencherListaDeCarro();
        }

        //classe criada para quebra do arquivo carro, criando o objeto Carro e depois cria uma lista de objetos carro
        public void PreencherListaDeCarro()
        {
            //O using automaticamente fecha os arquivos utilizados dentro do bloco 
            using (var arquivo = new StreamReader(arquivoDoEstoque))
            {
                string line;

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


        //recebe a lista de objetos carro e escreve no arquivo de Carro.
        //altera a lista do 
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


        public List<Carro> PegarListaDeCarro()
        {
            return listaDeCarro;

        }

        public void AdicionarCarrosNoEstoque(Carro carro)
        {
            listaDeCarro.Add(carro);
            AlterarListaDeCarro();
        }


        public int QuantidadeDeCarro(string marca, string modelo, int ano)
        {
            //LINQ sendo utilizado para contar os elementos de acordo com a busca
            int quantidade = listaDeCarro.Count(carro => carro.marca.Equals(marca) && carro.modelo.Equals(modelo) && carro.ano.Equals(ano));

            return quantidade;
        }



        public bool VerificarAsInformaçoesDoCarro(Carro carro)
        {
            //verifica se o elemento existe na lista utilização do Collections
            bool verificarCarro = listaDeCarro.Exists(carros => carros.chassi.Equals(carro.chassi) && carros.marca.Equals(carro.marca) && carros.modelo.Equals(carro.modelo) &&
                                                               carros.cor.Equals(carro.cor) && carros.ano.Equals(carro.ano) && carros.valor.Equals(carro.valor));

            return verificarCarro;
        }



        public void AtualizarNaListaDeCarros(Carro carro)
        {
            //retorna o primeiro elemento encontrado correspondente ao objeto carro.
            //utilização da biblioteca LINQ para fazer a busca do carro através do Where
            //First para buscar somente o primeiro e unico elemento
            var carroParaRemover = listaDeCarro.Where(carros => carros.chassi.Equals(carro.chassi) && carros.marca.Equals(carro.marca) && carros.modelo.Equals(carro.modelo) &&
                      carros.cor.Equals(carro.cor) && carros.ano.Equals(carro.ano) && carros.valor.Equals(carro.valor)).First();

            listaDeCarro.Remove(carroParaRemover);
            AlterarListaDeCarro();

        }

        //colocar todos os elementos de uma lista
        public List<Carro> PesquisarPelaMarca(string marca)
        {
            //pegar cada marca da lista do objeto Carro e comparar com a marca da busca.
            //armazenar todos os resultados em uma lista
            List<Carro> listaDeCarroDaBuscaPorMarca = listaDeCarro.FindAll(carro => carro.marca.Equals(marca));

            return listaDeCarroDaBuscaPorMarca;
        }

        public List<Carro> PesquisarPeloModelo(string modelo)
        {
            //pegar cada modelo da lista do objeto Carro e comparar com o modelo da busca.
            //armazenar todos os resultados em uma lista
            List<Carro> listaDeCarroDaBuscaPorModelo = listaDeCarro.FindAll(carro => carro.modelo.Equals(modelo));

            return listaDeCarroDaBuscaPorModelo;
        }


        public List<Carro> PesquisarPelaCor(string cor)
        {
            //pegar cada cor da lista do objeto Carro e comparar com a cor da busca.
            //armazenar todos os resultados em uma lista
            List<Carro> listaDeCarroPelaCor = listaDeCarro.FindAll(carro => carro.cor.Equals(cor));

            return listaDeCarroPelaCor;
        }

    }

}
