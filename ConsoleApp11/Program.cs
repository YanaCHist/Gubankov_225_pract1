using System;

namespace Gubankovchick
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, AC, BC;

            Console.Write("Введите координату точки A: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату точки B: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату точки C: ");
            x3 = Convert.ToDouble(Console.ReadLine());

            AC = Math.Abs(x3 - x1); // расстояние между точками A и C
            BC = Math.Abs(x3 - x2); // расстояние между точками B и C

            Console.WriteLine(" AC = " + AC);
            Console.WriteLine(" BC = " + BC);
            Console.WriteLine(" AC + BC = " + (AC + BC));

            Console.ReadLine();
        }
    }
}

