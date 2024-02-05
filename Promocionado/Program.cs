using System;
class Promocionado
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ïngresar la primera nota");
            double Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ïngresar la segunda nota");
            double Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ïngresar la tercera nota");
            double Num3 = double.Parse(Console.ReadLine());

            //Calcular promedio//

            double Promedio = (Num1 + Num2 + Num3) / 3;
            Console.WriteLine($"El promedio es:{Promedio}");

            //Ver si el promedio es mayor o igual a 7//

            if (Promedio >= 7)
            {

                Console.WriteLine("Promocionado");
            }
            else
            {
                Console.WriteLine("No promocionado");

            }
            //exepciones//
        }
        catch (FormatException)
        {
            Console.WriteLine("Ingresar una valor valido");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error. enter para salir: {ex.Message}");
        }
    }
}
