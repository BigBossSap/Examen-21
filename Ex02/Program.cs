using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0, producto = 1, unitats = 0;
            int aux;

            Console.WriteLine("Introducix un numero a comprovar: ");
            num = Convert.ToInt32(Console.ReadLine());
            aux = num;

            while (num > 0)
            {

                unitats = num % 10;
                num = num / 10;
                suma += unitats;

                producto *= unitats;

            }

            if (suma == producto)
            {
                Console.WriteLine($"La suma de les xifres de {aux} es {suma}, i el resultat de multiplicar les seves xifres es {producto}.");
                Console.WriteLine("Coincideix!");
            }

            else
            {
                Console.WriteLine($"La suma de las xifres de {aux} es {suma}, i el resultat de multiplicar les seves xifres es {producto}");
                Console.WriteLine("No coincideix!");
            }

        }
    }
}