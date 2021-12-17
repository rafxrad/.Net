namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double nota {get; set;}

        public override void Apresentar() 
        {
            System.Console.WriteLine($"O aluno se chama {Nome}, tem {Idade} anos e sua nota foi {nota}.");

        }
    }
}