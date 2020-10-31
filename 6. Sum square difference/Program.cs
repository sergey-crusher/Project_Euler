using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Количество натуральных чисел
            int n = 100;

            //Сумма квадратов n первых натуральных чисел
            int sum1 = (n * (n + 1)*(2 * n + 1)) / 6;

            //Сумма n первых натуральных чисел в квадрате
            int sum2 = (int)Math.Pow(((n * (n + 1)) / 2), 2);

            //Результат
            Console.WriteLine(sum2-sum1);
            Console.ReadKey();
        }
    }
}

#region
/*
 * The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
 * The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */
#endregion
