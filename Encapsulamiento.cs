using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    internal class Program
    {

        class CuentaBancaria
        {
            private decimal saldo;

            public CuentaBancaria()
            {
                saldo = 0;
            }

            public void Depositar(decimal cantidad)
            {
                if (cantidad > 0)
                {
                    saldo += cantidad;
                    Console.WriteLine($"Se depositaron {cantidad}.");
                }
                else
                {
                    Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
                }
            }

            public void Retirar(decimal cantidad)
            {
                if (cantidad <= 0)
                {
                    Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
                }
                else if (cantidad > saldo)
                {
                    Console.WriteLine("No hay suficiente saldo para retirar esa cantidad.");
                }
                else
                {
                    saldo -= cantidad;
                    Console.WriteLine($"Se retiraron {cantidad}.");
                }
            }

            public decimal ObtenerSaldo()
            {
                return saldo;
            }
        }

        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();

            Console.Write("¿Cuánto deseas depositar? ");
            if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
            {
                cuenta.Depositar(deposito);
            }
            else
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("¿Deseas retirar dinero? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "s")
            {
                Console.Write("¿Cuánto deseas retirar? ");
                if (decimal.TryParse(Console.ReadLine(), out decimal retiro))
                {
                    cuenta.Retirar(retiro);
                }
                else
                {
                    Console.WriteLine("Cantidad no válida.");
                }
            }

            Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");
            Console.ReadLine();
        }
    }
}