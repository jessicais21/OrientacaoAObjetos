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
            //cria o objeto da vida real vendedor.
            Vendedor vendedor = new Vendedor(vendedorNomeCadastrarVenda.Text);
           
            //cria o objeto da  vida real cliente. 
            Cliente cliente = new Cliente(clienteRgCadastrarVenda.Text, nomeClienteCadastrarVenda.Text);

            //cria o objeto da vida real carro
            Carro carro = new Carro(chassiCarroCadastrarVenda.Text, marcaCarroCadastrarVenda.Text, modeloCarroCadastrarVenda.Text, corCarroCadastrarVenda.Text, Convert.ToInt32(anoCarroCadastrarVenda.Text), 
                                    Convert.ToDouble(valorCarroCadastrarVenda.Text));

            //o objeto controle de vendas é responsável por adicionar ou remover vendas.
            ControleDeVendas controleDeVendas = new ControleDeVendas();
            string confirmacaoDeVenda = controleDeVendas.VerificarDadosParaEfetuarVenda(vendedor, cliente, carro);
            MessageBox.Show(confirmacaoDeVenda);    
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }      

        private void click_todosOsCarros_Click(object sender, EventArgs e)
        {

            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var listaDeCarros = estoque.listaDeCarro;
            gridViewCarros.DataSource = listaDeCarros;
        }

        private void click_MostrarMarcas_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPelaMarca = estoque.PesquisarPelaMarcaDeCarros(MarcaPesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPelaMarca;

        }

        private void click_QuantidadeMarcaMostrar_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            int retornar = estoque.QuantidadeDeCarroDeAcordoComAMarca(MarcaPesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com a marca é: "+retornar);
        }

        private void Click_Mostrar_Modelos_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPeloModelo = estoque.PesquisarPeloModeloDeCarros(modelo_Pesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPeloModelo;
        }

        private void click_QuantidadeModelos_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            int retornar = estoque.QuantidadeDeCarroDeAcordoComOModelo(modelo_Pesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com o modelo é: " + retornar);

        }

        private void click_MostrarDeAcordoComACor_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPelaCor = estoque.PesquisarPelaCorDeCarros(cor_Pesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPelaCor;
        }

        private void click_quantidade_carro_corres_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var retornar = estoque.QuantidadeDeCarroDeAcordoComACor(cor_Pesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com a cor é: "+retornar);
        }

       

        private void click_ano_mostrar_carros_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPelaCor = estoque.PesquisarCarrosPorAno(Convert.ToInt32(ano_carro_pesquisar.Text));
            gridViewCarros.DataSource = resultadoDaBuscaPelaCor;
        }

        private void click_quantidade_cor_Click(object sender, EventArgs e)
        {
            //adiciona no estoque de carros que é o objeto responsável por controlar os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var retornar = estoque.QuantidadeDeCarroDeAcordoComOAno(Convert.ToInt32(ano_carro_pesquisar.Text));
            MessageBox.Show("a quantidade de carros de acordo com o ano é"+retornar);
        }

        private void click_todasAsVendas_Click(object sender, EventArgs e)
        {
          //então afirma que que dataSource é nulo
                this.dataGridVendas.DataSource = null;
          
            //então já que o dataGridVendas é nulo
           //limpar todas as linhas do dataGridView, 
                this.dataGridVendas.Rows.Clear();

            //o objeto controle de vendas é responsável por adicionar ou remover vendas.
            ControleDeVendas controleDeVendas = new ControleDeVendas();

            var listaDeVendas = controleDeVendas.listaDeVenda;


            //coluna do data grid view
            dataGridVendas.ColumnCount = 11;
            dataGridVendas.Columns[0].Name = "Numero";
            dataGridVendas.Columns[1].Name = "Data e hora";
            dataGridVendas.Columns[2].Name = "vendedor";
            dataGridVendas.Columns[3].Name = "cpf do cliente";
            dataGridVendas.Columns[4].Name = "nome do cliente";
            dataGridVendas.Columns[5].Name = "chassi do carro";
            dataGridVendas.Columns[6].Name = "marca do carro";
            dataGridVendas.Columns[7].Name = "modelo do carro";
            dataGridVendas.Columns[8].Name = "cor do carro";
            dataGridVendas.Columns[9].Name = "ano do carro";
            dataGridVendas.Columns[10].Name = "valor do carro";

            //escrever cada valor em uma string e passar a string para cada linha do dataGridView
            for (int i = 0; i < listaDeVendas.Count; i++)
               {
                //cria um array de string e armazena os dados da lista
                string[] row = new string[] {listaDeVendas[i].numeroDaVenda.ToString(),
                               listaDeVendas[i].dataEHorasDaVenda.ToString(),listaDeVendas[i].vendedor.nome,
                               listaDeVendas[i].cliente.rg,listaDeVendas[i].cliente.nome,
                               listaDeVendas[i].veiculo.chassi,listaDeVendas[i].veiculo.marca,listaDeVendas[i].veiculo.modelo,listaDeVendas[i].veiculo.cor,
                                listaDeVendas[i].veiculo.ano.ToString(),listaDeVendas[i].veiculo.valor.ToString()};
                //escrever em cada linha do gridView
                dataGridVendas.Rows.Add(row);
            }

          
        }

        private void click_mostrar_Click(object sender, EventArgs e)
        {

            //então afirma que que dataSource é nulo
            this.dataGridVendas.DataSource = null;

            //limpar todas as linhas do dataGridView, 
            this.dataGridVendas.Rows.Clear();

            //o objeto controle de vendas é responsável por adicionar ou remover vendas.
            ControleDeVendas controleDeVendas = new ControleDeVendas();

            var listaDeVendas = controleDeVendas.BuscarPorDataOuHora(pesquisarPorDataOuHora.Text);


            //coluna do data grid view
            //cria um array para colunas
            dataGridVendas.ColumnCount = 11;
            dataGridVendas.Columns[0].Name = "Numero";
            dataGridVendas.Columns[1].Name = "Data e hora";
            dataGridVendas.Columns[2].Name = "vendedor";
            dataGridVendas.Columns[3].Name = "cpf do cliente";
            dataGridVendas.Columns[4].Name = "nome do cliente";
            dataGridVendas.Columns[5].Name = "chassi do carro";
            dataGridVendas.Columns[6].Name = "marca do carro";
            dataGridVendas.Columns[7].Name = "modelo do carro";
            dataGridVendas.Columns[8].Name = "cor do carro";
            dataGridVendas.Columns[9].Name = "ano do carro";
            dataGridVendas.Columns[10].Name = "valor do carro";

            for (int i = 0; i < listaDeVendas.Count; i++)
            {
                //cria um array de strings para aparecer no gridView
                string[] row = new string[] {listaDeVendas[i].numeroDaVenda.ToString(),
                               listaDeVendas[i].dataEHorasDaVenda.ToString(),listaDeVendas[i].vendedor.nome,
                               listaDeVendas[i].cliente.rg,listaDeVendas[i].cliente.nome,
                               listaDeVendas[i].veiculo.chassi,listaDeVendas[i].veiculo.marca,listaDeVendas[i].veiculo.modelo,listaDeVendas[i].veiculo.cor,
                                listaDeVendas[i].veiculo.ano.ToString(),listaDeVendas[i].veiculo.valor.ToString()};
                //escrever em cada linha
                dataGridVendas.Rows.Add(row);
            }

        }

        private void click_cancelar_Click(object sender, EventArgs e)
        {
            //cria o objeto da  vida real cliente. 
            Cliente cliente = new Cliente(clienteRgCadastrarVenda.Text, nomeClienteCadastrarVenda.Text);

            //cria o objeto da vida real carro
            Carro carro = new Carro(chassiCarroCadastrarVenda.Text, marcaCarroCadastrarVenda.Text, modeloCarroCadastrarVenda.Text, corCarroCadastrarVenda.Text, Convert.ToInt32(anoCarroCadastrarVenda.Text),
                                    Convert.ToDouble(valorCarroCadastrarVenda.Text));

            //o objeto controle de vendas é responsável por adicionar ou remover vendas.
            ControleDeVendas controleDeVendas = new ControleDeVendas();         
            string confirmacaoDeCancelamentoDeVenda = controleDeVendas.VerificarDadosParaOCancelamentoDeVenda(cliente, carro);

            MessageBox.Show(confirmacaoDeCancelamentoDeVenda);

        }
    }
}
