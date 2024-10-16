using Herança_2;

Gato gato1 = new Gato
{
    Especie = "Felino"
};

Console.WriteLine("A especie do gato é uma especie de:" + gato1.Especie);
gato1.EmitirSom();

Porco porco1 = new Porco
{
    Especie = "Mamifero"
};

Console.WriteLine("\nA especie do porco é uma especie de:" + porco1.Especie);
porco1.EmitirSom();

Capivara capivara1 = new Capivara
{
    Especie = "Roedor"
};

Console.WriteLine("\nA capivara é uma especie de:" + capivara1.Especie);
capivara1.EmitirSom();















Console.ReadLine();