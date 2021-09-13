using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_V1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Taschenrechner");
            Console.WriteLine("Gebe die erste Zahl ein die du Berechnen willst");
            int Zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gebe die zweite Zahl ein die du Berechnen willst");
            int Zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe +, -, *, / ein");
            String Rechenzeichen = Console.ReadLine();
            int rechner = Rechner(Zahl1, Zahl2, Rechenzeichen);
            Console.WriteLine(rechner);
            Console.ReadKey();
            
            

        }
        static int Rechner(int Zahl1, int Zahl2, string Rechenzeichen)

        {

            
            switch (Rechenzeichen)
            {
                case "*":
                    return Zahl1 * Zahl2;
                    
                case "/":
                    if (Zahl1 > Zahl2)
                        return Zahl1 / Zahl2;
                    else
                        return Zahl1 / Zahl2;
                    
                case "+":
                    return Zahl1 + Zahl2;

                case "-":
                    return Zahl1 - Zahl2;
                    break;
                default:
                    Console.WriteLine("Bitte gebe +, -, *, / ein");
                    break;
            }
            Console.ReadKey();
            return 0;
            
       
        
        }
        
           
        
    }
}
