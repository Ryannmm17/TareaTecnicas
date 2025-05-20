using System;
using System.Collections.Generic;

interface IAnimal
{
    void HacerSonido();
}

class Perro : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau, guau!");
    }
}

class Gato : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("El gato maúlla: ¡Miau, miau!");
    }
}

class Program
{
    static void Main()
    {
        List<IAnimal> animales = new List<IAnimal>
        {
            new Perro(),
            new Gato()
        };

        foreach (IAnimal animal in animales)
        {
            animal.HacerSonido();
        }

        Console.ReadLine();
    }
}