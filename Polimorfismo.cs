using System;

namespace FigurasGeometricas
{
    // Clase abstracta que define el concepto de una figura geométrica
    abstract class Figura
    {
        // Método abstracto que cada figura debe implementar para calcular su área
        public abstract double CalcularArea();
    }

    // Implementación de un cuadrado, que extiende Figura
    class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Cuadrado - Lado: {lado}, Área: {CalcularArea()}");
        }
    }

    // Implementación de un triángulo, que extiende Figura
    class Triangulo : Figura
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Triángulo - Base: {baseTriangulo}, Altura: {altura}, Área: {CalcularArea()}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creación de objetos con valores ingresados por el usuario
            Console.WriteLine("Ingrese el lado del cuadrado:");
            double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(ladoCuadrado);

            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

            // Mostrar información de las figuras creadas
            cuadrado.MostrarInformacion();
            triangulo.MostrarInformacion();

            // Evitar cierre inmediato de la consola
            Console.ReadLine();
        }
    }
}