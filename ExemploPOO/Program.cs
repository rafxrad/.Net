using System;


namespace ExemploPOO.Models{
    class Program {
        static void Main(string[] args)


        {


            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 28;

            

            Aluno a1 = new Aluno();
            a1.Nome = "Igor";
            a1.Idade = 20;
            a1.nota = 7.6;
            
            a1.Apresentar();
            System.Console.WriteLine($"Sua nota foi {a1.nota}");



            // Retangulo R = new Retangulo();

            // R.DefinirMedidas(13.0, 24.0);
            // R.ObterArea();

            // System.Console.WriteLine($"Área: {R.ObterArea()}");


            // Retangulo R2 = new Retangulo();

            // R.DefinirMedidas(0, 24.0);
            // R.ObterArea();

            // System.Console.WriteLine($"Área: {R2.ObterArea()}");

        }
    }
}