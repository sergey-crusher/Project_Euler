﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    #region
    /*
     * Each new term in the Fibonacci sequence is generated by adding the previous two terms.
     * By starting with 1 and 2, the first 10 terms will be:
     * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
     * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
     * find the sum of the even-valued terms.
     */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Сумма всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона
            int res = 0;
            int cRes = 1;
            int lastRes = 1;

            while (true)
            {
                if ((cRes += lastRes) < 4_000_000)
                {
                    lastRes = cRes - lastRes;
                    if (cRes % 2 == 0)
                    {
                        res += cRes;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
