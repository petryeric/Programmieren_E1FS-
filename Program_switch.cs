using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In welchem Monat befinden wir uns?");
            string input = Console.ReadLine();
            int Monat = int.Parse(input);

            switch (Monat)
            {
                case 1:
                    Console.WriteLine("Es ist Januar");
                    break;
                case 2:
                    Console.WriteLine("Es ist Februar");
                    break;
                case 3:
                    Console.WriteLine("Es ist März");
                    break;
                case 4:
                    Console.WriteLine("Es ist April");
                    break;
                case 5:
                    Console.WriteLine("Es ist Mai");
                    break;
                case 6:
                    Console.WriteLine("Es ist Juni");
                    break;
                case 7:
                    Console.WriteLine("Es ist Juli");
                    break;
                case 8:
                    Console.WriteLine("Es ist August");
                    break;
                case 9:
                    Console.WriteLine("Es ist September");
                    break;
                case 10:
                    Console.WriteLine("Es ist Oktober");
                    break;
                case 11:
                    Console.WriteLine("Es ist November");
                    break;
                case 12:
                    Console.WriteLine("Es ist Dezember");
                    break;
                default:
                    Console.WriteLine("Bitte nur Zahlen von 1 bis 12 angeben");
                    break;


            }
            Console.ReadKey();
        }
    }
}
