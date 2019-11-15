using System;

namespace array
{
    class Program
    {
        static int[] BubbleSort(int[] mas, string met)
        {
            int temp;
            if (met == "max")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
            }
            if (met == "min")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] < mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Input n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] random_arr = new int[n];
            Console.WriteLine("Input min array value");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input max array value");
            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                random_arr[i] = rand.Next(min, max);
                Console.Write($"{random_arr[i]} ");
            }
            Console.WriteLine("Choose a sorting method, max or min");
            string method = Convert.ToString(Console.ReadLine());
            BubbleSort(random_arr, method);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{random_arr[i]} ");
            }
        }
    }
}
