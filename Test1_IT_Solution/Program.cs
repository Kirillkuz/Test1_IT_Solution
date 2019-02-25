using System;

namespace Test1_IT_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел вы хотите вывести в ряд?");
            //Введенное число
            int n= Convert.ToInt32(Console.ReadLine());
            //Шаг для вывода чисел
            int k = 1;
            //Число с которого начинаем вывод
            int m = 0;
            //Разрядность
            int r = 10;
            Console.WriteLine("1-значные числа");
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write($"{m}; ");
                m += k;
                if (m>=r)
                {
                    m = r;
                    r *= 10;
                    k++;
                    while (m % k != 0)
                        m++;
                    Console.WriteLine($"\n{k}-значные числа");
                }
            }
            Console.Read();
        }
    }
}
