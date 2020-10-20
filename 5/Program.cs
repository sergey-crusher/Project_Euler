using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        /// <summary>
        /// Функция нахождения НОД
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double nod(double a, double b)
        {
            while (b > 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        /// <summary>
        /// Функция нахождения НОК
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double nok(double a, double b)
        {
            return Math.Abs(a * b) / nod(a, b);
        }

        static void Main(string[] args)
        {
            //Первичное наполнение
            List<double> temp = new List<double>();
            List<double> res = new List<double>();
            for (int i=1; i<21; i++)
            {
                temp.Add(i);
            }

            //Попарное применение НОК, до тех пор, пока не останется одна запись
            while (temp.Count > 2)
            {
                res.Clear();
                for (int i = 0; i < temp.Count - 1; i++)
                {
                    res.Add(nok(temp[i], temp[i + 1]));
                }
                temp.Clear();
                temp.AddRange(res);
            }
            Console.WriteLine(res[0]);
            Console.ReadKey();
        }
    }
}

#region
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
#endregion