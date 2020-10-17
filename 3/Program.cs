using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    #region
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */
    #endregion
class Program
{
    static void Main(string[] args)
    {
        long input = 13195; //result 5, 7, 13, 29
        input = 600851475143;
        var array = new HashSet<int>();
        long side = input;
        long div = 2;

        while (side > 1)
        {
            while (side % div == 0)
            {
                side /= div;
                Console.Clear();
                Console.Write(div + " ");
            }
            if (div == 2) div++;
            //else if (div + 2 % 5 != 0 || div == 5) div += 2;
            else div += 2;
        }
        Console.ReadKey();
    }
}
}
