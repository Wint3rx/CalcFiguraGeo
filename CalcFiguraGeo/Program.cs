using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Área de Figuras Geométricas");

        try
        {
            Console.Write("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo): ");
            string tipoFigura = Console.ReadLine().ToLower();

            double area = 0;

            switch (tipoFigura)
            {
                case "triangulo":
                    area = CalcularAreaTriangulo();
                    break;
                case "cuadrado":
                    area = CalcularAreaCuadrado();
                    break;
                case "circulo":
                    area = CalcularAreaCirculo();
                    break;
                default:
                    throw new ArgumentException("Tipo de figura no válido");
            }

            Console.WriteLine($"El área del {tipoFigura} es: {area}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static double CalcularAreaTriangulo()
    {
        Console.Write("Ingrese la base del triángulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        return 0.5 * baseTriangulo * alturaTriangulo;
    }

    static double CalcularAreaCuadrado()
    {
        Console.Write("Ingrese el lado del cuadrado: ");
        double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

        return ladoCuadrado * ladoCuadrado;
    }

    static double CalcularAreaCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radioCirculo = Convert.ToDouble(Console.ReadLine());

        return Math.PI * radioCirculo * radioCirculo;
    }
}

