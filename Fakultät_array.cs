using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultät
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Fakultät von n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultcounter = 0;

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                resultcounter++;
                int[] results = new int[resultcounter];
                result = results[resultcounter];

            }


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
