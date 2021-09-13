using System;

namespace Übungsaufgabe_13092021
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

           

            Console.WriteLine(program.Rechner(5.0, 6.0));

        }

        public double Rechner(double zahl1, double zahl2)
        {
            Console.WriteLine("Geben Sie die Rechenoperation ein");
            string Operation = Console.ReadLine();

            switch (Operation)
            {
                case "Addition":
                    return zahl1 + zahl2;
                    
                case "Subtraktion":
                    if (zahl1 < zahl2)
                    {
                        return -(zahl2 - zahl1);
                    }
                    else
                    {
                        return zahl1 - zahl2;
                    }
                   
                case "Multiplikation":
                    return zahl1 * zahl2;
                    
                case "Division":
                    double Ergebnis = zahl1 / zahl2;
                    return Ergebnis;
                case "Mod":
                    return zahl1 % zahl2;
                   
                default:
                    Console.WriteLine("Bitte geben Sie eine korrekte Operation ein");
                    
                    return 0;

            }





        }        
            }



        }

   

