using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first INTEGER value");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second INTEGER value");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write sign");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"first + second = {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"first - second = {first - second}");
                    break;
                case "/":
                    Console.WriteLine($"first / second = {first / second}");
                    break;
                case "*":
                    Console.WriteLine($"first * second = {first * second}");
                    break;
                default:
                    Console.WriteLine("You write kaka, change your sign. \n" +
                        $"Look on your sign, may be it's not sign?It's - {sign}. Please try again.");
                    break;
            }
        }
    }
}
