using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zähler = 0;
            Console.WriteLine("Welche Art von Zahl soll angegeben werden?");
            string input = Console.ReadLine();
           
            while (Zähler <= 100)
            {
                if (Zähler % 2 == 0 && input == "gerade")
                {
                    Console.WriteLine(Zähler + " ist eine gerade Zahl");

                }
                else if (Zähler % 2 == 1 && input == "ungerade") 
                {
                    Console.WriteLine(Zähler + " ist eine ungerade Zahl");
                }
             
                Zähler++;
            }
            Console.ReadKey();
        }
    }
}
