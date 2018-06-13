using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!");
            

            int entier = 5;
            int entier2 = entier;
            Console.WriteLine($"entier={entier};entier2={entier2}");

            Toto toto = new Toto();
            toto.entier = 5;
            Toto toto2 = new Toto();
            toto.entier = 6;

            Console.WriteLine($"toto.entier={toto.entier};toto2.entier={toto2.entier}");

            const int NbDeJours= 7;
            
            Console.ReadKey();

            for (int index=1; index <=10; index++)
            {
                Console.WriteLine(index);
            }
             
        }


            class Toto
        {
            public int entier;
        }

        
    
        }
    
}
