namespace ExemploPOO.Models
{
    public class CCorrente : Conta
    {
        public double tarifa;

        public override void Creditar(double valor)
        {
            this.saldo = saldo + valor;
        }
    }
}