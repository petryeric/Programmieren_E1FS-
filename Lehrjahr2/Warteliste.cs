using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
namespace Warteliste
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            ArrayList Warteliste = new ArrayList();

            Warteliste.Add("Luca");
            Warteliste.Add("Dennis");
            Warteliste.Add("Boris");
            Warteliste.Add("Leon");
            Warteliste.Add("Hakki");
            Warteliste.Add("Nico");
            Warteliste.Add("Franziska");

            do
            {
                
                Console.WriteLine("Type Next to continue");
                string eingabe = Console.ReadLine();
                if(eingabe == "Next")
                {
                    object currentitem = Warteliste[count];

                    Console.WriteLine(currentitem);
                        }
                count++;
            } while (count != Warteliste.Count);

            Console.WriteLine("There is no further Item in the List, Press Enter to Abort");
            Console.ReadKey();


           
        }
    }
}
