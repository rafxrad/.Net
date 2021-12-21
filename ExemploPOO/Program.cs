using System;
using ExemploPOO.Helper;

namespace ExemploPOO.Models{
    class Program {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\weiss\\Documents\\ExemploPOO";
            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);


            // CCorrente c1 = new CCorrente();
            // c1.Creditar(3000);
           
            // c1.exibirSaldo();

            // CCorrente c2 = new CCorrente();
            // c2.tarifa = 3000;
            // c2.Creditar(50000);
            // c2.exibirSaldo();


            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 28;
            // p1.Apresentar();

            

            // Aluno a1 = new Aluno();
            // a1.Nome = "Igor";
            // a1.Idade = 20;
            // a1.nota = 7.6;
            
            // a1.Apresentar();
            


            // Professor prof1 = new Professor();
            // prof1.Nome = "Levy";
            // prof1.Idade = 30;
            // prof1.salario = 5000.0;

            // prof1.Apresentar();

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