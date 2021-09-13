using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEITUNGEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int Paralellsumme = 0;
            int Reihenschaltung = 0;
            Console.WriteLine("Wie viele Wiederstände willst du haben?");
                string input = Console.ReadLine();
                int anzahl = int.Parse(input);
            int[] x = new int[anzahl];
            int Stelle = 1;
            for (int i = 0; i < anzahl; i++)
            {
                
                Console.WriteLine("Geben Sie den " + Stelle +" ten Wert an");
                
                int inhalt = int.Parse(Console.ReadLine());


                x[i] = inhalt;
                

                Stelle++;


            }
            Console.WriteLine("1 für Reinschaltung und 2 für Paralellschaltung");
            string lol = Console.ReadLine();
            if (lol == "1") {

                Reihenschaltung = x.Sum();
                Console.WriteLine(Reihenschaltung);
            }
                //Reihenschaltung
              

            //Paralell
            else if (lol == "2")
            {
                for (int j = 1; j < anzahl; j++)
                {



                    Paralellsumme += 1 / x[j];

                }
                Console.WriteLine(1/Paralellsumme);

            }
                
            
            Console.ReadKey();
       



        }
    }
}
