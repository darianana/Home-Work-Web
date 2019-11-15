using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для анализа:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double k = 0;
            string word_last = "";
            foreach (string s in words)
            {
                k++;
            }
            Console.WriteLine($"Количество слов:{k}");
            double symbol = text.Length - (k - 1);
            Console.WriteLine($"Количество символов без пробелов:{symbol}");
            double relati = symbol / k;
            Console.WriteLine($"Соотношение количество символов без пробелов к количеству слов:{Math.Round(relati, 2)}");
            for (int i = 0; i < words.Length; i++)
            {
                word_last += words[i][words[i].Length - 1];
            }
            Console.WriteLine($"Слово из последних символов слов:{word_last}");

        }
    }
}
