using System;

namespace Gubankovchick
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, U, T1, T2, S;
            Console.Write("Введите скорость лодки в стоячей воде: ");
            V = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость течения: ");
            U = double.Parse(Console.ReadLine());
            Console.Write("Введите время движения лодки по озеру: ");
            T1 = double.Parse(Console.ReadLine());
            Console.Write("Введите время движения лодки по реке(против течения): ");
            T2 = double.Parse(Console.ReadLine());
            S = V * T1 + (V - U) * T2;
            Console.WriteLine("Лодка прошла путь равный: " + S);
        }
    }
}
