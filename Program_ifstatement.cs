using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter = 17;
            bool premium = true;

            if(alter >= 18 && premium == true)
            {
                Console.WriteLine("Sie dürfen bei uns Filme Streamen, Willkommen und viel Spaß!");
            }
            else
            {
                Console.WriteLine("Sie dürfen keine Filme bei uns Streamen, Fuck You !");
            }
        }
    }
}
