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
                else
                {
                    Console.WriteLine("Tschüss");
                }



            }
            else { Console.WriteLine("Tschüss"); }
            Console.ReadKey();
        }
    }
}
