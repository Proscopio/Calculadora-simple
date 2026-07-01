using System;

class Calculadora
{
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir por cero.");

        return a / b;
    }

    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("===== CALCULADORA =====");

        Console.Write("Ingrese el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSeleccione una operación:");
        Console.WriteLine("1 - Sumar");
        Console.WriteLine("2 - Restar");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Potencia");

        Console.Write("Opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = calc.Sumar(n1, n2);
                break;

            case 2:
                resultado = calc.Restar(n1, n2);
                break;

            case 3:
                resultado = calc.Multiplicar(n1, n2);
                break;

            case 4:
                resultado = calc.Dividir(n1, n2);
                break;

            case 5:
                resultado = calc.Potencia(n1, n2);
                break;

            default:
                Console.WriteLine("Opción inválida.");
                return;
        }

        Console.WriteLine($"\nResultado: {resultado}");
    }
}