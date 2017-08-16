using Cappta.LojaDeCarro.Estoque;
using Cappta.LojaDeCarro.Pessoas;
using Cappta.LojaDeCarro.Venda;
using System;
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
            try
            { //Vendedor é um objeto porque representa um vendedor da vida real. 
              //Neste sistema, é o vendedor da concessionária de carros.
                Vendedor vendedor = new Vendedor(vendedorNomeCadastrarVenda.Text);

                //Cliente é um objeto porque representa um cliente da concessionária.  
                Cliente cliente = new Cliente(clienteRgCadastrarVenda.Text, nomeClienteCadastrarVenda.Text);
 
                int anoCarro;
                //converte um valor de um txt para um int, e retorna se a operação foi bem-sucedida.
                bool resultadoAnoCarro = int.TryParse(anoCarroCadastrarVenda.Text, out anoCarro);

         
                if(resultadoAnoCarro == false) {                 
                    throw new FormatException("ano invalido");
                }

                double valorCarro;

                //converte um valor de um txt para um double, e retorna se a operação foi bem-sucedida.
                bool resultadoValorCarro = double.TryParse(valorCarroCadastrarVenda.Text, out valorCarro);

                if (resultadoValorCarro == false)
                {
                    throw new FormatException("valor invalido");
                }

                //Carro é um objeto porque representa um carro. 
                Carro carro = new Carro(chassiCarroCadastrarVenda.Text, marcaCarroCadastrarVenda.Text, modeloCarroCadastrarVenda.Text, corCarroCadastrarVenda.Text,anoCarro, valorCarro);
              

                //Controle de vendas é um objeto porque representa operações de venda como adicionar e cancelar venda.
                ControleDeVendas controleDeVendas = new ControleDeVendas();
                string confirmacaoDeVenda = controleDeVendas.VerificarDadosParaEfetuarVenda(vendedor, cliente, carro);
                MessageBox.Show(confirmacaoDeVenda);
            }

            //Exceção gerada durante a criação do objeto
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Erro nos dados de: "+ex.Message);
            }

            //Exceção geranda que os valores ainda não foram convertidos para a criação do objeto carro
            catch (FormatException ex)
            {
                MessageBox.Show("Insira os valores nos formatos corretos " + ex.Message);
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }      

        private void click_todosOsCarros_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var listaDeCarros = estoque.listaDeCarro;
            gridViewCarros.DataSource = listaDeCarros;
        }

        private void click_MostrarMarcas_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPelaMarca = estoque.PesquisarPelaMarcaDeCarros(MarcaPesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPelaMarca;

        }

        private void click_QuantidadeMarcaMostrar_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            int retornar = estoque.QuantidadeDeCarroDeAcordoComAMarca(MarcaPesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com a marca é: "+retornar);

         
        }

        private void Click_Mostrar_Modelos_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPeloModelo = estoque.PesquisarPeloModeloDeCarros(modelo_Pesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPeloModelo;
            
        }

        private void click_QuantidadeModelos_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            int retornar = estoque.QuantidadeDeCarroDeAcordoComOModelo(modelo_Pesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com o modelo é: " + retornar);
            
        }

        private void click_MostrarDeAcordoComACor_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPelaCor = estoque.PesquisarPelaCorDeCarros(cor_Pesquisar.Text);
            gridViewCarros.DataSource = resultadoDaBuscaPelaCor;
          
        }

        private void click_quantidade_carro_corres_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var retornar = estoque.QuantidadeDeCarroDeAcordoComACor(cor_Pesquisar.Text);
            MessageBox.Show("a quantidade de carros de acordo com a cor é: "+retornar);
          
        }

       

        private void click_ano_mostrar_carros_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
            EstoqueDeCarro estoque = new EstoqueDeCarro();
            var resultadoDaBuscaPelaCor = estoque.PesquisarCarrosPorAno(Convert.ToInt32(ano_carro_pesquisar.Text));
            gridViewCarros.DataSource = resultadoDaBuscaPelaCor;
          
        }

        private void click_quantidade_cor_Click(object sender, EventArgs e)
        {
            //Estoque de carros é um objeto porque controla os carros
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
            dataGridVendas.Columns[0].Width = 50;
            dataGridVendas.Columns[1].Name = "Data e hora";
            dataGridVendas.Columns[1].Width = 120;
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
            GridViewVendas();
          
        }

        private void click_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cliente é um objeto porque representa um cliente da co. 
                Cliente cliente = new Cliente(clienteRgCadastrarVenda.Text, nomeClienteCadastrarVenda.Text);

                int anoCarro;
                //converte um valor de um txt para um int, e retorna se a operação foi bem-sucedida
                bool resultadoAnoCarro = int.TryParse(anoCarroCadastrarVenda.Text, out anoCarro);

                if (resultadoAnoCarro == false)
                {
                    throw new FormatException("ano invalido");
                }

                double valorCarro;
                //converte um valor de um txt para um double, e retorna se a operação foi bem-sucedida.
                bool resultadoValorCarro = double.TryParse(valorCarroCadastrarVenda.Text, out valorCarro);
               
                if (resultadoValorCarro == false)
                {
                    throw new FormatException("valor invalido");
                }

                //Carro é um objeto porque representa um carro da vida real.
                Carro carro = new Carro(chassiCarroCadastrarVenda.Text, marcaCarroCadastrarVenda.Text, modeloCarroCadastrarVenda.Text, corCarroCadastrarVenda.Text,anoCarro,valorCarro);

                //o objeto controle de vendas é responsável por adicionar ou remover vendas.
                ControleDeVendas controleDeVendas = new ControleDeVendas();
                string confirmacaoDeCancelamentoDeVenda = controleDeVendas.VerificarDadosParaOCancelamentoDeVenda(cliente, carro);

                MessageBox.Show(confirmacaoDeCancelamentoDeVenda);
            }

            //Exceção gerada durante a criação do objeto
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Dados invalidos: " +ex.Message);
            }

            //Exceção geranda que os valores ainda não foram convertidos para a criação do objeto carro
            catch (FormatException ex)
            {
                MessageBox.Show("Insira os valores nos formatos corretos" +ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void GridViewVendas()
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
    }
}
