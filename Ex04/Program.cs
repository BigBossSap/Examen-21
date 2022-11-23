using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1,digit=0, j=1;
            string numfinal="";
            Console.WriteLine("Numero enter:");
            num = Int32.Parse(Console.ReadLine());

            while (j<=num)
            {

                digit = i;
                numfinal = digit + " " + numfinal;


                i+=2;
                j++;

                Console.WriteLine(numfinal);
            }





        }
    }
}
