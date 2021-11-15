using System;
using System.Collections;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Warteliste = new ArrayList();

            Warteliste.Add("Luca");
            Warteliste.Add("Dennis");
            Warteliste.Add("Boris");
            Warteliste.Add("Leon");
            Warteliste.Add("Hakki");
            Warteliste.Add("Nico");
            Warteliste.Add("Franziska");

            Warteliste.Sort();

            foreach(object o in Warteliste)
            {
                Console.WriteLine(o);
            }
        }
    }
}
