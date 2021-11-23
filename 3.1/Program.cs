using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1, 2-й вариант, средний уровень, Гребенюк
            try
            {
                Console.WriteLine("Введите значение x: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение k: ");
                int k = int.Parse(Console.ReadLine());
                double P = 1;
                int t = 2;
                for (t = 2; t <= k; t++)
                {
                    if (t == 12 || t == 0) continue;
                    P *= (t * Math.Pow(x, t) / t - 12);
                }
                double S = 0;
                for (int i = 1; i <= t; i++)
                {
                    if (i == 4 || i == 6) continue;
                    S += (i - 4 / i - 6);
                }
                Console.WriteLine($"U={P * S:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
