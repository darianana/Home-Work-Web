using System;

namespace Formulki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер желаемой формулы:");
            Console.WriteLine("1. N = ( (x^2 + y + sqrt(z)) / y ), z > 0");
            Console.WriteLine("2. N = lg(sin(Pi/x) * k");
            Console.WriteLine("3. N = 2 * sin(x) * cos(y) / (x + y) ^ z");
            Console.WriteLine("4. N = ((x * (sqrt(x) + y^3)) / Pi), x > 0");
            int number = Convert.ToInt32(Console.ReadLine());
            double n = 0;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введите х:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите у:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите z > 0:");
                    double z = Convert.ToDouble(Console.ReadLine());
                    n = ((x * x + y + Math.Sqrt(z)) / y);
                    Console.WriteLine($"{n}");
                    break;
                case 2:
                    Console.WriteLine("Введите х:");
                    double j = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите k:");
                    double k = Convert.ToDouble(Console.ReadLine());
                    n = Math.Log10(Math.Sin(Math.PI / j)) * k;
                    Console.WriteLine($"{n}");
                    break;
                case 3:
                    Console.WriteLine("Введите х:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите z:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    n = 2 * Math.Sin(a) * Math.Cos(b) / Math.Pow(a + b, c);
                    Console.WriteLine($"{n}");
                    break;
                case 4:
                    Console.WriteLine("Введите х > 0:");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y:");
                    double t = Convert.ToDouble(Console.ReadLine());
                    n = ((r * (Math.Sqrt(r) + Math.Pow(t, 3))) / Math.PI);
                    Console.WriteLine($"{n}");
                    break;
                default:
                    Console.WriteLine("Выберите другой номер формулы");
                    break;
            }
        }
    }
}
