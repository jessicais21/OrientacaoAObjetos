using System;

using Cappta.LojaDeCarro.Estoque;
using Cappta.LojaDeCarro.Pessoas;
using Cappta.LojaDeCarro.Venda;

namespace ConsoleApp1
{
    public class Program
    {
        //objeto sendo criado porque representa algo real, 
        //quando eu crio um new então 
        static Estoque estoque = new Estoque();
        static ControleDeVendas controleDeVendas = new ControleDeVendas();

        static void Main(string[] args)
        {

            for (;;)
            {
                Console.Write("Tela de login");
                Console.Write("\n");

                int escolha = menu();

                Console.Write("\n");

                switch (escolha)
                {
                    case 1:
                        SairDoPrograma();
                        break;

                    case 2:
                        RetornarListaDeCarro();
                        break;

                    case 3:
                        PesquisarEstoque();
                        break;

                    case 4:
                        RetornarListaDeVenda();
                        break;

                    case 5:
                        EfetuarVendas();
                        break;

                    case 6:
                        PesquisarPorMarca();
                        break;

                    case 7:
                        PesquisarPorModelo();
                        break;

                    case 8:
                        PesquisarPelaCor();
                        break;

                    case 9:
                        CancelamentoDeVenda();
                        break;

                    case 10:
                        PesquisarPorDataOuHora();
                        break;
                }
            }

        }

        public static int menu()
        {

            Console.WriteLine("1 - sair");
            Console.WriteLine("2 - carregar lista de carros");
            Console.WriteLine("3 - quantidade de elementos no estoque");
            Console.WriteLine("4 - visualizar vendas");
            Console.WriteLine("5 - adicionar vendas");
            Console.WriteLine("6 - pesquisar de acordo com a marca do carro");
            Console.WriteLine("7 - pesquisar o modelo do carro");
            Console.WriteLine("8 - pesquisar a cor do carro");
            Console.WriteLine("9 - cancelar a venda");
            Console.WriteLine("10 - pesquisar por data ou hora");
            int escolha = Convert.ToInt32(Console.ReadLine());

            return escolha;
        }

        public static void SairDoPrograma()
        {
            Environment.Exit(0);
        }

        public static void RetornarListaDeCarro()
        {
            var listaDeCarros = estoque.PegarListaDeCarro();
          
          
            foreach (var listarCarros in listaDeCarros)
            {
                Console.WriteLine("Chassi: " + listarCarros.chassi);
                Console.WriteLine("Marca: " + listarCarros.marca);
                Console.WriteLine("Modelo: " + listarCarros.modelo);
                Console.WriteLine("Cor: " + listarCarros.cor);
                Console.WriteLine("Ano: " + listarCarros.ano);
                Console.WriteLine("Valor: " + listarCarros.valor);
                Console.WriteLine();
            }
        }

        public static void RetornarListaDeVenda()
        {
            var listaDeVendas = controleDeVendas.PegarListaDeVenda();

            foreach (var listarVendas in listaDeVendas)
            {
                Console.WriteLine("Codigo da venda: " + listarVendas.codigo);
                Console.WriteLine("Date e hora da venda: " + listarVendas.dataEHora);
                Console.WriteLine("Nome do vendedor: " + listarVendas.vendedor.nome);
                Console.WriteLine("Rg do cliente: " + listarVendas.cliente.rg);
                Console.WriteLine("Nome do cliente: " + listarVendas.cliente.nome);
                Console.WriteLine("Chassi do veiculo: " + listarVendas.veiculo.chassi);
                Console.WriteLine("Marca do veiculo: " + listarVendas.veiculo.marca);
                Console.WriteLine("Modelo do veiculo: " + listarVendas.veiculo.modelo);
                Console.WriteLine("Cor do veiculo:" + listarVendas.veiculo.cor);
                Console.WriteLine("Ano do veiculo: " + listarVendas.veiculo.ano);
                Console.WriteLine("Valor do veiculo: " + listarVendas.veiculo.valor);
                Console.WriteLine();
            }
        }

        public static void PesquisarPorMarca()
        {
            Console.Write("marca: ");
            string marca = Console.ReadLine();

            var resultadoDaBuscaPelaMarca = estoque.PesquisarPelaMarcaDeCarros(marca);

            foreach (var listarCarros in resultadoDaBuscaPelaMarca)
            {
                Console.WriteLine("Chassi: " + listarCarros.chassi);
                Console.WriteLine("Marca: " + listarCarros.marca);
                Console.WriteLine("Modelo: " + listarCarros.modelo);
                Console.WriteLine("Cor: " + listarCarros.cor);
                Console.WriteLine("Ano: " + listarCarros.ano);
                Console.WriteLine("Valor: " + listarCarros.valor);
                Console.WriteLine();
            }

        }

        public static void PesquisarPorModelo()
        {
            Console.Write("modelo: ");
            string modelo = Console.ReadLine();

            var resultadoDaBuscaPeloModelo = estoque.PesquisarPeloModeloDeCarros(modelo);

           
            foreach (var listarCarros in resultadoDaBuscaPeloModelo)
            {
                Console.WriteLine("Chassi: " + listarCarros.chassi);
                Console.WriteLine("Marca: " + listarCarros.marca);
                Console.WriteLine("Modelo: " + listarCarros.modelo);
                Console.WriteLine("Cor: " + listarCarros.cor);
                Console.WriteLine("Ano: " + listarCarros.ano);
                Console.WriteLine("Valor: " + listarCarros.valor);
                Console.WriteLine();
            }

        }

        public static void PesquisarPelaCor()
        {
            Console.Write("cor: ");
            string cor = Console.ReadLine();

            var resultadoDaBuscaPelaCor = estoque.PesquisarPelaCorDeCarros(cor);

            foreach (var listarCarros in resultadoDaBuscaPelaCor)
            {
                Console.WriteLine("Chassi: " + listarCarros.chassi);
                Console.WriteLine("Marca: " + listarCarros.marca);
                Console.WriteLine("Modelo: " + listarCarros.modelo);
                Console.WriteLine("Cor: " + listarCarros.cor);
                Console.WriteLine("Ano: " + listarCarros.ano);
                Console.WriteLine("Valor: " + listarCarros.valor);
                Console.WriteLine();
            }
        }

        public static void PesquisarEstoque()
        {
            Console.Write("Digite marca do carro");
            string marca = Console.ReadLine();

            Console.Write("Digite o modelo do carro");
            string modelo = Console.ReadLine();

            Console.Write("Digite o ano do carro");
            int anoDoCarro = Convert.ToInt32(Console.ReadLine());

            int retornar = estoque.QuantidadeDeCarro(marca, modelo, anoDoCarro);

            Console.WriteLine("quantidade de elementos no estoque: "+retornar);

        }

        public static void EfetuarVendas()
        {
            Console.Write("nome do vendedor: ");
            string nomeDoVendedor = Console.ReadLine();

            Console.Write("rg do cliente: ");
            string rg = Console.ReadLine();
            Console.Write("nome do cliente: ");
            string nomeDoCliente = Console.ReadLine();

            Console.Write("chassi do carro: ");
            string chassiDoCarro = Console.ReadLine();
            Console.Write("marca do carro: ");
            string marca = Console.ReadLine();
            Console.Write("modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("cor do carro: ");
            string cor = Console.ReadLine();
            Console.Write("ano do carro: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("valor do carro: ");
            double valor = Double.Parse(Console.ReadLine());

            Vendedor vendedor = new Vendedor(nomeDoVendedor);
            Cliente cliente = new Cliente(rg, nomeDoCliente);
            Carro carro = new Carro(chassiDoCarro, marca, modelo, cor, ano, valor);

            bool checarInformacoesDoCarro = estoque.VerificarAsInformaçoesDoCarro(carro);

            if (checarInformacoesDoCarro)
            {
                DateTime localDate = DateTime.Now;
                Console.WriteLine("data e hora da venda: " + localDate);
                estoque.RemoverCarros(carro);
                int identificador = controleDeVendas.GerarIdentificadorDaVenda();
                Venda venda = new Venda(identificador, localDate, vendedor, cliente, carro);
                controleDeVendas.AdicionarElementosNaListaDeVendas(venda);
                Console.WriteLine("venda realizada com sucesso\n");
            }


            else
            {
                Console.WriteLine("a venda não pode ser realizada, dados incorretos do carro");
            }
        }

        public static void CancelamentoDeVenda()
        {
            Console.Write("rg do cliente: ");
            string rg = Console.ReadLine();
            Console.Write("nome do cliente: ");
            string nomeDoCliente = Console.ReadLine();

            Console.Write("chassi do carro: ");
            string chassiDoCarro = Console.ReadLine();
            Console.Write("marca do carro: ");
            string marca = Console.ReadLine();
            Console.Write("modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("cor do carro: ");
            string cor = Console.ReadLine();
            Console.Write("ano do carro: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("valor do carro: ");
            double valor = Double.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(rg, nomeDoCliente);
            Carro carro = new Carro(chassiDoCarro, marca, modelo, cor, ano, valor);

            var verificarDadosDeCancelamento = controleDeVendas.VerificarDadosParaOCancelamentoDeVenda(cliente, carro);

            if (verificarDadosDeCancelamento)
            {
                controleDeVendas.EfetuarOCancelamentoDeVenda(cliente, carro);
                estoque.AdicionarCarros(carro);
                Console.WriteLine("cancelamento efetuado com sucesso");
            }

            else
            {
                Console.WriteLine("dados incorretos para o cancelamento de venda");
            }
        }


        public static void PesquisarPorDataOuHora()
        {
            Console.Write("data(../../....) ou hora da venda da venda(..:..:..): ");
            string data = Console.ReadLine();

            var ResultadoDaBuscaPorDataOUHora = controleDeVendas.BuscarPorDataOuHora(data);

            foreach (var listarVendas in ResultadoDaBuscaPorDataOUHora)
            {
                Console.WriteLine("Codigo da venda: " + listarVendas.codigo);
                Console.WriteLine("Date e hora da venda: " + listarVendas.dataEHora);
                Console.WriteLine("Nome do vendedor: " + listarVendas.vendedor.nome);
                Console.WriteLine("Rg do cliente: " + listarVendas.cliente.rg);
                Console.WriteLine("Nome do cliente: " + listarVendas.cliente.nome);
                Console.WriteLine("Chassi do veiculo: " + listarVendas.veiculo.chassi);
                Console.WriteLine("Marca do veiculo: " + listarVendas.veiculo.marca);
                Console.WriteLine("Modelo do veiculo: " + listarVendas.veiculo.modelo);
                Console.WriteLine("Cor do veiculo:" + listarVendas.veiculo.cor);
                Console.WriteLine("Ano do veiculo: " + listarVendas.veiculo.ano);
                Console.WriteLine("Valor do veiculo: " + listarVendas.veiculo.valor);
                Console.WriteLine();
            }
        }

    }
}





