
namespace Cappta.LojaDeCarro.Estoque
{
    //usar a interface é um contrato, não é uma classe.
    //toda a classe que assina o contrato, sera obrigada a ter essas propriedades
    //da a liberdade da classe que faz a assinatura ter várias interfaces
    //não ter a lógica do método

   public interface IVeiculo
    {
        string chassi { get; set; }
        string modelo { get; set; }
        string marca { get; set; }
        string cor { get; set; }
        int ano { get; set; }
        double valor { get; set; }
    }
}
