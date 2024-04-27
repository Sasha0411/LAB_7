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
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 11); // Генерація випадкового числа в діапазоні від 1 до 10
            }

            // Обчислення суми елементів, які більші за 5
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 5)
                {
                    sum += numbers[i];
                }
            }

            // Виведення результату
            Console.WriteLine("Сума елементів, які більші за 5: {0}", sum);
        }
    }
}
