using System;


namespace ExemploPOO.Models{
    class Program {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Rafa";
            p1.Idade = 28;

            p1.Apresentar();
        }
    }
}