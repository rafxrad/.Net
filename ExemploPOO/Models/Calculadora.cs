using ExemploPOO.interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int x, int y)
        {
           return x / y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Somar(int x, int y)
        {
           return x + y;
        }

        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}