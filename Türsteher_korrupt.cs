using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie alt bist du?");
            string input = Console.ReadLine();
            int alter = int.Parse(input);

            if (alter >= 18)
            {
                Console.WriteLine("Ausweis?");
                string input2 = Console.ReadLine();
                bool ausweis = bool.Parse(input2);

                if (ausweis == true)
                {
                    Console.WriteLine("Viel Spaß im Club");
                }
               else if(ausweis == false)
                {
                    Console.WriteLine("Bist du bereit zu zahlen?");
                    string input3 = Console.ReadLine();
                    bool spende = bool.Parse(input3);
                    if(spende == true)
                    {
                        Console.WriteLine("Wie hoch ist die Spende?");
                        string input4 = Console.ReadLine();
                        int summe = int.Parse(input4);
                        if(summe >= 100)
                        {
                            Console.WriteLine("Danke für die Spende, du kannst eintreten ");
                        }
                        else
                        {
                            Console.WriteLine("Solche niedrigen Summen nehme ich nicht an");
                        }
                    }
                }
                
                else {
                    Console.WriteLine("Tschüss");
                }



            }
            else { Console.WriteLine("Tschüss"); }
            Console.ReadKey();
        }
    }
}
