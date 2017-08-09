using System;
using System.Collections.Generic;
using System.IO;

namespace Cappta.LojaDeCarro.Estoque
{
    //classe criada para armazenar o carro
   public class Estoque
    {

        public List<Carro> listaDeCarro { get; set; } = new List<Carro>();

        //somente para visualização do arquivo
        //private para ser visualizado somente nessa classe
        
        private string arquivoDoEstoque = "carro.txt";
        //@ cadeia de caracteres de textuais
        public Estoque()
        {
            PreencherListaDeCarro();
        }


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

                    Carro carro = new Carro(identificador, marca, modelo, cor,ano, valor);
                    listaDeCarro.Add(carro);
                }
            }
        }

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
    }
       
    }
