using System;
using System.Collections.Generic;

// Definimos la interfaz IAnimal que obliga a las clases que la implementen a definir el método HacerSonido()
interface IAnimal
{
    void HacerSonido();
}

// Implementación de un perro, que debe definir su propio sonido
class Perro : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau, guau!");
    }
}

// Implementación de un gato, que también debe definir su propio sonido
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
        // Lista de animales donde se almacenan objetos que implementan IAnimal
        List<IAnimal> animales = new List<IAnimal>
        {
            new Perro(), // Se añade un perro
            new Gato()   // Se añade un gato
        };

        // Se recorre la lista y se llama al método HacerSonido() de cada objeto
        foreach (IAnimal animal in animales)
        {
            animal.HacerSonido();
        }

        // Pausa la ejecución para ver los resultados antes de que la consola se cierre
        Console.ReadLine();
    }
}