using System;

// Clase base que representa a un empleado
class Empleado
{
    public string Nombre { get; set; }  // Nombre del empleado
    public decimal Salario { get; set; } // Salario del empleado

    // Constructor de la clase base
    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método virtual para mostrar información del empleado
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario: ${Salario}");
    }
}

// Clase Gerente, que hereda de Empleado
class Gerente : Empleado
{
    public string Departamento { get; set; } // Departamento al que pertenece

    // Constructor de la clase Gerente
    public Gerente(string nombre, decimal salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Sobrescritura del método para incluir información adicional
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario: ${Salario}, Departamento: {Departamento}");
    }
}

// Clase Desarrollador, que también hereda de Empleado
class Desarrollador : Empleado
{
    public string Lenguaje { get; set; } // Lenguaje de programación que domina

    // Constructor de la clase Desarrollador
    public Desarrollador(string nombre, decimal salario, string lenguaje)
        : base(nombre, salario)
    {
        Lenguaje = lenguaje;
    }

    // Sobrescritura del método para incluir información adicional
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario: ${Salario}, Lenguaje de Programación: {Lenguaje}");
    }
}

class Program
{
    static void Main()
    {
        // Instanciación de objetos con los nombres solicitados
        Gerente carlos = new Gerente("Carlos", 100000, "Administración");
        Desarrollador patricia = new Desarrollador("Patricia", 90000, "C++");
        Desarrollador marcela = new Desarrollador("Marcela", 65000, "FullStack");

        // Llamada a los métodos para mostrar la información
        carlos.MostrarInformacion();
        patricia.MostrarInformacion();
        marcela.MostrarInformacion();
        Console.ReadLine();
    }
}