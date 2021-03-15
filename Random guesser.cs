using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_guesser
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int Zufall = rnd.Next(1, 100);

            
            while(true)
            {
                Console.WriteLine("Bitte geben sie eine zahl zwischen 1 und 100 an");
                int eingabe = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Zufall);
                if (eingabe > Zufall)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                }
                else if(eingabe < Zufall)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer");
                }
                else
                {
                    break;
                }
            }
            



        }
    }
}
