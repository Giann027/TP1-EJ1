using System;

namespace TP1_EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Suma de dos Números ";
            int Numero1;
            int Numero2;
            int Suma;
            Console.Write("Ingrese El Primer Número:");
            Numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese El Segundo Número:");
            Numero2 = Convert.ToInt32(Console.ReadLine());

            Suma = (Numero1 + Numero2);
            Console.Write($"El resultado de la suma es {Suma}");
        }
    }
}
