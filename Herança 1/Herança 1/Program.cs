using Herança_1;

/* Funcionario 1 */
Funcionario funcionario1 = new Funcionario
{
    Nome = "Leca Berto",
    Idade = 47
};
funcionario1.Envelhecer(10); //somar a idade indicada

Console.WriteLine($"Nome: {funcionario1.Nome}, Idade: {funcionario1.Idade}");

/*Funcionario 2*/
Funcionario funcionario2 = new Funcionario
{
    Nome = "Vitoria Bougleux",
    Idade = 26
};
funcionario2.FonteDaJuventude(10); //subtrair a idade indicada

Console.WriteLine($"Nome: {funcionario2.Nome}, Idade: {funcionario2.Idade}");

/*Funcionario 3*/
Funcionario funcionario3 = new Funcionario
{
    Nome = "Thomas Correa",
    Idade = 17
};
funcionario3.Envelhecer(10); //subtrair a idade indicada

Console.WriteLine($"Nome: {funcionario3.Nome}, Idade: {funcionario3.Idade}");



Console.ReadKey();
