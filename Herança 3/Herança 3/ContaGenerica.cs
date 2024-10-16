namespace Herança_3
{
    public abstract class ContaGenerica
    {
        public string Banco {  get; set; }

        public int Agencia { get; set; }

        public int Conta { get; set; }

        public string Saldo { get; set; }

        public abstract void Depositar();

        public abstract void Sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public string Limite { get; set; }
        public override void Sacar()
        {
            Console.WriteLine("Voce sacou 1.000,00");
        }

        public override void Depositar()
        {
            Console.WriteLine("Voce depositou 4.000,00");
        }
    }
}
