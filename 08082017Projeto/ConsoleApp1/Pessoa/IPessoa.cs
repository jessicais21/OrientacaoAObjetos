
namespace Cappta.LojaDeCarro.Pessoas
{
    //usar a interface porque é um contrato, não é uma classe.
    //toda a classe que assina o contrato, sera obrigada a ter essas propriedades
    //da a liberdade da classe que assina ter várias interfaces
    //não coloco a lógica na propriedade

 public interface IPessoa
    {
        string nome { get; set; }
    }
}
