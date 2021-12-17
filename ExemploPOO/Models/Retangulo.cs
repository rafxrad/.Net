namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        private Boolean valido;

        public void DefinirMedidas(double comprimento, double largura) 
        {

            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("valores inválidos.");
            }
        }

        public double ObterArea()
        {
            if (valido) {
                return comprimento * largura;
            }

            System.Console.WriteLine("preencha valores válidos.");
            return 0;
           

        }
    }
}