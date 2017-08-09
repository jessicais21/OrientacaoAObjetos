//coleção de um mesmo tipo de dado
using System.Collections.Generic;
using Cappta.LojaDeCarro.Pessoas;
using Cappta.LojaDeCarro.Estoque;
using System.Linq;


namespace Cappta.LojaDeCarro.Venda
{
    public class ControleDeVendas
    {
        BancoDeVendas bancoDeVendas = new BancoDeVendas();

        public List<Venda> PegarListaDeVenda()
        {
            return bancoDeVendas.listaDeVenda;
        }


        public void AdicionarElementosNaListaDeVendas(Venda venda)
        {
            bancoDeVendas.listaDeVenda.Add(venda);
            bancoDeVendas.Atualizar();
        }


        public int GerarIdentificadorDaVenda()
        {
            //ordena a lista de venda para ser descendente de acordo com o codigo da lista de objetos e coloca o ultima venda como primeira
            var ultimoRegistroDoCodigo = bancoDeVendas.listaDeVenda.OrderByDescending(venda => venda.codigo).First();

            int gerarIdentificador = ultimoRegistroDoCodigo.codigo + 1;

            return gerarIdentificador;
        }

        public bool VerificarDadosParaOCancelamentoDeVenda(Cliente cliente, Carro carro)
        {
            //metodo exist do colection para verificar se existe um dado da busca
            bool verificarVenda = bancoDeVendas.listaDeVenda.Exists(venda => venda.cliente.rg.Equals(cliente.rg) && venda.cliente.nome.Equals(cliente.nome)
                    && venda.veiculo.chassi.Equals(carro.chassi) &&
                    venda.veiculo.marca.Equals(carro.marca) && venda.veiculo.modelo.Equals(carro.modelo) &&
                    venda.veiculo.cor.Equals(carro.cor) && venda.veiculo.ano.Equals(carro.ano) &&
                    venda.veiculo.valor.Equals(carro.valor));

            return verificarVenda;
        }

        public void EfetuarOCancelamentoDeVenda(Cliente cliente, Carro carro)
        {
            //linq sendo utilizado para buscar uma venda na lista de vendas -> utilização do where
            var removerAVenda = bancoDeVendas.listaDeVenda.Where(venda => venda.cliente.rg.Equals(cliente.rg) && venda.cliente.nome.Equals(cliente.nome) &&
                    venda.veiculo.chassi.Equals(carro.chassi) &&
                    venda.veiculo.marca.Equals(carro.marca) && venda.veiculo.modelo.Equals(carro.modelo) &&
                    venda.veiculo.cor.Equals(carro.cor) && venda.veiculo.ano.Equals(carro.ano) &&
                    venda.veiculo.valor.Equals(carro.valor)).First();

            bancoDeVendas.listaDeVenda.Remove(removerAVenda);

            bancoDeVendas.Atualizar();

        }


        public List<Venda> BuscarPorDataOuHora(string dataOuHora)
        {
            //converte o atributo data para string e pergunta se nessa string contem a data buscada e armazena em uma lista
            //armazena todos os elementos da lista baseado na busca por data ou hora através do FindAll
            List<Venda> listaDeBuscaDeVendas = bancoDeVendas.listaDeVenda.FindAll(vendas => vendas.dataEHora.ToString().Contains(dataOuHora));

            return listaDeBuscaDeVendas;
        }
    }

}
