using Herança_3;

ContaCorrente ContaCorrente = new ContaCorrente
{
    Limite = "9.000,00",
    Banco = "Bradesco",
    Agencia = 9732,
    Conta = 10192-4,
    Saldo = "5.000,00",
};

Console.WriteLine("Banco " + ContaCorrente.Banco);
Console.WriteLine("Conta " + ContaCorrente.Conta);
Console.WriteLine("Agencia " + ContaCorrente.Agencia);

Console.WriteLine("\nSaldo: " + ContaCorrente.Saldo);
Console.WriteLine("Limite: " + ContaCorrente.Limite);

ContaCorrente.Depositar();
ContaCorrente.Sacar();