using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schaultung
{
    class Program
    {
        double Endsumme = 0;
        double Paralellsumme = 0;
       
        double Zwischenrechnung = 0;
        static void Main(string[] args)
        {

        }

        
        static double Reihenschaltung(int Anzahl)
        {

            
            double[] x = new double[Anzahl];


            for (int i = 0; i < Anzahl; i++)
            {
                int Stelle = 1;

                Console.WriteLine("Geben Sie den " + Stelle + " ten Wert an");

                double inhalt = double.Parse(Console.ReadLine());


                x[i] = inhalt;


                Stelle++;



            }
            return x.Sum();
        }

        static double Parallellschaltung(int Anzahl)
        {
                double Endsumme = 0;
                double Paralellsumme = 0;
                double Reihenschaltung = 0;
                double Zwischenrechnung = 0;
                double[] x = new double[Anzahl];

            for (int i = 0; i < Anzahl; i++)
            {
                int Stelle = 1;

                Console.WriteLine("Geben Sie den " + Stelle + " ten Wert an");

                double inhalt = double.Parse(Console.ReadLine());


                x[i] = inhalt;


                Stelle++;



            }

                for (int j = 0; j < Anzahl; j++)
                {




                    Zwischenrechnung += (1 / x[j]);





                }
                Endsumme = 1 / Zwischenrechnung;
                return Endsumme;

            }

        
    }


}
