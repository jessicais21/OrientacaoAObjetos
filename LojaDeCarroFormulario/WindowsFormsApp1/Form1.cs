using Cappta.LojaDeCarro.Estoque;
using Cappta.LojaDeCarro.Pessoas;
using Cappta.LojaDeCarro.Venda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_cadastrar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor(vendedorNomeCadastrarVenda.Text);
           
            Cliente cliente = new Cliente(clienteRgCadastrarVenda.Text, nomeClienteCadastrarVenda.Text);

            Carro carro = new Carro(chassiCarroCadastrarVenda.Text, marcaCarroCadastrarVenda.Text, modeloCarroCadastrarVenda.Text, corCarroCadastrarVenda.Text, Convert.ToInt32(anoCarroCadastrarVenda.Text), 
                                    Convert.ToDouble(valorCarroCadastrarVenda.Text));

            Estoque estoque = new Estoque();
            bool checarInformacoesDoCarro = estoque.VerificarSeOCarroExisteNoEstoque(carro);

            if (checarInformacoesDoCarro)
            {
                DateTime localDate = DateTime.Now;
                Console.WriteLine("data e hora da venda: " + localDate);
                estoque.RemoverCarros(carro);
                ControleDeVendas controleDeVendas = new ControleDeVendas();
                int identificador = controleDeVendas.GerarIdentificadorDaVenda();
                Venda venda = new Venda(identificador, localDate, vendedor, cliente, carro);
                controleDeVendas.AdicionarVendas(venda);
                MessageBox.Show ("venda realizada com sucesso\n");
            }


            else
            {
                MessageBox.Show("a venda não pode ser realizada, dados incorretos do carro");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }      

        private void click_todosOsCarros_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var listaDeCarros = estoque.listaDeCarro;
            gridViewCarros.DataSource = listaDeCarros;
        }

        private void click_MostrarMarcas_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var resultadoDaBuscaPelaMarca = estoque.PesquisarPelaMarcaDeCarros(MarcaPesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPelaMarca;

        }

        private void click_QuantidadeMarcaMostrar_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            int retornar = estoque.QuantidadeDeCarroDeAcordoComAMarca(MarcaPesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com a marca é: "+retornar);
        }

        private void Click_Mostrar_Modelos_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var resultadoDaBuscaPeloModelo = estoque.PesquisarPeloModeloDeCarros(modelo_Pesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPeloModelo;
        }

        private void click_QuantidadeModelos_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            int retornar = estoque.QuantidadeDeCarroDeAcordoComOModelo(modelo_Pesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com o modelo é: " + retornar);

        }

        private void click_MostrarDeAcordoComACor_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var resultadoDaBuscaPelaCor = estoque.PesquisarPelaCorDeCarros(cor_Pesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPelaCor;
        }

        private void click_quantidade_carro_corres_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var retornar = estoque.QuantidadeDeCarroDeAcordoComACor(cor_Pesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com a cor é: "+retornar);
        }

       

        private void click_ano_mostrar_carros_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var resultadoDaBuscaPelaCor = estoque.PesquisarCarrosPorAno(Convert.ToInt32(ano_carro_pesquisar.Text));
            gridViewCarros.DataSource = resultadoDaBuscaPelaCor;
        }

        private void click_quantidade_cor_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            var retornar = estoque.QuantidadeDeCarroDeAcordoComOAno(Convert.ToInt32(ano_carro_pesquisar.Text));
            MessageBox.Show("a quantidade de carros de acordo com o ano é"+retornar);
        }

        private void click_todasAsVendas_Click(object sender, EventArgs e)
        {
            //  dataGridVendas.AutoGenerateColumns = false;
            dataGridVendas.DataSource = null;
            DataTable table = new DataTable();
            table.Columns.Add("IDENTIFICADOR",typeof(int));

            ControleDeVendas controleDeVendas = new ControleDeVendas();

            var listaDeVendas = controleDeVendas.listaDeVenda;

            //    dataGridVendas.AutoGenerateColumns = false;

           // List<String> minhaLista = new List<String>();

            foreach (var listarVendas in listaDeVendas)
            {
              //  minhaLista.Add(listarVendas.identificadorDaVenda.ToString());
                table.Rows.Add(listarVendas.identificadorDaVenda);
                visualizarVendasText.Text+="Codigo da venda: " + listarVendas.identificadorDaVenda+"Date e hora da venda: " + listarVendas.dataEHorasDaVenda+
               "Nome do vendedor: " + listarVendas.vendedor.nome +"Rg do cliente: " + listarVendas.cliente.rg+ "Nome do cliente: " + listarVendas.cliente.nome
               +"Chassi do veiculo: " + listarVendas.veiculo.chassi+"Marca do veiculo: " + listarVendas.veiculo.marca+"Modelo do veiculo: " + listarVendas.veiculo.modelo
               +"Cor do veiculo:" + listarVendas.veiculo.cor+"Ano do veiculo: " + listarVendas.veiculo.ano+"Valor do veiculo: " + listarVendas.veiculo.valor 
               + "==========================================";
            
            }
            dataGridVendas.DataSource = listaDeVendas;
            //  Estoque estoque = new Estoque();
            //  var listaDeCarros = estoque.listaDeCarro;
            //gridViewCarros.DataSource = listaDeCarros;
            //dataGridVendas.DataSource = listaDeVendas;
            //    dataGridVendas.AutoGenerateColumns = false;
            //      DataGridViewColumn coluna = new DataGridViewColumn();
            //     coluna.HeaderText = "Codigo";
            //    coluna.Name = "Codigo";
            //  coluna.Visible = true;
            //  coluna.Width = 40;
            //  dataGridVendas.Columns.Add(coluna);

            //  for (int i=0;i<listaDeVendas.Count;i++)
            //{
            //   dataGridVendas.Rows.Add(listaDeVendas[i].identificadorDaVenda);
            // }

            //   List<Venda> minhaLista = listaDeVendas;
            // */


        }
    }
}
