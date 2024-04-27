using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            // Створення та ініціалізація масиву
            int[] numbers = new int[30];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100); // Генерація випадкового числа в діапазоні від -100 до 100
            }

            // Знаходження максимального від'ємного елемента
            int maxNegative = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0 && numbers[i] > maxNegative)
                {
                    maxNegative = numbers[i];
                }
            }

            // Виведення результату
            if (maxNegative == int.MinValue)
            {
                Console.WriteLine("В масиві немає від'ємних чисел.");
            }
            else
            {
                Console.WriteLine("Максимальний від'ємний елемент: {0}", maxNegative);
            }
        }
    }
}
