using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int cont1=0, cont2=0, unitats;

            
            
            Console.WriteLine("n:");
            n = Int32.Parse(Console.ReadLine());

            while (n>0)
            {
                unitats = n % 10;
                n = n / 10;
             

                if (unitats == 4)
                    cont1++;
                
                if (unitats == 9)
                    cont2++;
                
            }

            

            if (cont1==2 && cont2==1)
                Console.WriteLine($"Es compleix la condicio te com a minim {cont1} quatres i {cont2} nous");
            else
                Console.WriteLine($"No es compleix, te {cont1} quatres i {cont2} nous");




        }
    }
}
