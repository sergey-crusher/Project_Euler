using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10_001;                                                                 //Количество простых чисел
            int i = 1;                                                                      //Отчёт с 1, т.к её нет в массиве
            int number = 3;                                                                 //Начальное число для цикла
            List<int> numbers = new List<int>();                                            //Массив полученных простых чисел
            numbers.Add(2);                                                                 //Добавляем двойку
            bool check = true;                                                              //Для проверки - является ли простым

            while (i < n)
            {
                check = true;
                //Проверка - является ли число простым
                foreach (int item in numbers)
                {
                    if (number % item == 0)
                        check = false;
                }
                //Если является, добавляем его в массив
                if (check)
                {
                    numbers.Add(number);
                    Console.WriteLine($"{number} ");
                    i++;
                }
                number += 2;                                                                //Пропускаем все чётные числа
            }
            Console.ReadKey();
        }
    }
}

#region
//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10 001st prime number?

//Выписав первые шесть простых чисел, получим 2, 3, 5, 7, 11 и 13. Очевидно, что 6-ое простое число - 13.
//Какое число является 10001-ым простым числом?

//104743
#endregion