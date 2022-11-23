using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i,j, result;
            Console.WriteLine("Numero a multiplicar: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"La taula de multiplicar del {n} es:");
                     
                for (i = 1; i <= 10; i++)
                {
                    result = n * i;

                    Console.WriteLine($"{n} x {i} = {result}");
                                         
                }

            n = n + 1; 
            Console.WriteLine();
            Console.WriteLine($"La taula de multiplicar del {n} es:");

            for (i = 1; i <= 10; i++)
            {

                
                result = n * i;

                Console.WriteLine($"{n} x {i} = {result}");
            }

        }
    }
}
