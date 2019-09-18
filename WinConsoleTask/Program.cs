using System;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, res;
            try
            {
                Console.WriteLine("Введіть значення x:");
                x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть значення y:");
                y = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть значення z:");
                z = Double.Parse(Console.ReadLine());

                res = (2 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, 2 - z))) + (z * z / (7 - z / 3));
                Console.WriteLine("{0}", res);
            }
            catch {
                Console.WriteLine("Помилка введення!");
            }
            Console.ReadKey();
        }
    }
}
