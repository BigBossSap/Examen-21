using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            string guanyador = "";
            string aposta = "";
                     
            while (i<13)
            {
                Random random = new Random();
                int resultat = random.Next(0, 3);
                i++;
                if (resultat == 1)
                    guanyador += "X";
                else
                    guanyador += resultat;               
            }

            Console.WriteLine("Introdueix la teva aposta: ");
            aposta = Console.ReadLine();

            
            int aciertos = 0;
            while (j<13)
            {
                if (guanyador[j]==aposta[j])
                {
                    
                    aciertos++;

                }
                j++;                

            }

            Console.WriteLine($"La convinacio guanyadora es: {guanyador}");
            Console.WriteLine($"La teva aposta ha estat : {aposta} i has tingut {aciertos} acerts!!!");

            


            //Console.WriteLine("El cuarto caracter de la cadena1 es:{0}",cadena1[3]);








        }
    }
}
