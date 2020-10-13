using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static public string Revers (uint input)
        {
            char[] sReverse = input.ToString().ToCharArray();
            Array.Reverse(sReverse);
            string res = "";
            foreach (char item in sReverse)
            {
                res += item;
            }
            return res;
        }

        static void Main(string[] args)
        {
            uint result = 0;
            List<uint> list = new List<uint>();
            for (uint i = 999; i > 100; i--)
            {
                for (uint j = 999; j > 100; j--)
                {
                    result = i * j;
                    if (result.ToString().Substring(0,3) == Revers(result).Substring(0, 3))
                    {
                        list.Add(result);
                        break;
                    }
                }
            }
            Console.WriteLine(list.Max());
            Console.ReadKey();
        }
    }
}