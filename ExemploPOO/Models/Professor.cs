namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario {get; set;}
    

    public override void Apresentar() 
    {
        System.Console.WriteLine($"O nome do professor é {Nome}, sua idade é {Idade} e seu salário é {salario}");

    }

    }
}