using System;
using CSharp;
using Interface;

namespace CSharp
{
    public class Programa
    {
        static void Main(String[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Rafa";
            person.Idade = 28;
            person.Cidade = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Cidade = "Belo Horizonte";
            person2.Idade = 24;


            Animal animal = new Animal();

            animal.Nome = "Chico";
            animal.Especie = "Cachorro";
            animal.Dono = "Rafa";

            


        }
    }
}