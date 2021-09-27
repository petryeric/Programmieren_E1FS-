using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schaultung
{
    class Program
    {
        static void Main(string[] args)
        {
            double Endsumme = 0;
            double Paralellsumme = 0;
            double Reihenschaltung = 0;
            double Zwischenrechnung = 0;
            Console.WriteLine("Wie viele Wiederstände willst du haben?");
            string input = Console.ReadLine();
            int anzahl = int.Parse(input);
            double[] x = new double[anzahl];
            int Stelle = 1;
           
            for (int i = 0; i < anzahl; i++)
            {

                Console.WriteLine("Geben Sie den " + Stelle + " ten Wert an");

                double inhalt = double.Parse(Console.ReadLine());


                x[i] = inhalt;


                Stelle++;


            }

            Console.WriteLine("1 für Reinschaltung und 2 für Paralellschaltung");
            string Angabe = Console.ReadLine();
            if (Angabe == "1")
            {

                Reihenschaltung = x.Sum();
                Console.WriteLine(Reihenschaltung);
            }
            //Reihenschaltung


            //Paralell
            else if (Angabe == "2")
            {
                for (int j = 1; j < anzahl; j++)
                {


                    
                    
                    Zwischenrechnung += ( 1 / x[j];

                    
                    
                    

                }
                Endsumme = 1 / Zwischenrechnung;

                Console.WriteLine(Endsumme);

            }


            Console.ReadKey();




        }
    }
}
