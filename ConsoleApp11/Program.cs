using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {


            //4 Дана длина ребра куба a. Найти объем куба V и площадь его поверхности S.
            Console.WriteLine("Введите длинну ребра куба:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Обьем куба:" + Math.Pow(a, 3) + " куб.см");
            Console.WriteLine("Площадь поверхности:" + Math.Pow(a, 2) * 6 + " кв.см");//площать стороны * 6 сторон куба
            Console.ReadLine();
        }
    }
}
