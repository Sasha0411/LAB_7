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

            // Введення даних з клавіатури
            Console.WriteLine("Введіть 10 чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Знаходження максимального та мінімального елементів
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            // Обчислення суми (або добутку) елементів, розташованих між максимальним і мінімальним
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > min && numbers[i] < max)
                {
                    sum += numbers[i];
                }
            }

            // Виведення результату
            Console.WriteLine("Сума елементів, розташованих між максимальним і мінімальним: {0}", sum);
        }
    }
}
