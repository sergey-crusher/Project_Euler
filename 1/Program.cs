using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    #region
    /* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
     * The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    #endregion
class Program
{
    static void Main(string[] args)
    {
        //Сумма всех чисел меньше 1000, кратных 3 или 5
        int res = 0;
        for (int val = 1; val < 1000; val++)
        {
            if (val % 3 == 0 || val % 5 == 0)
            {
                res += val;
            }
        }

        Console.WriteLine(res);
        Console.ReadKey();
    }
}
}
