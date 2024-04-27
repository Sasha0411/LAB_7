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

            int[] numbers = { 5, 3, 10, 2, 7 };

            // Обчислення середнього арифметичного значення
            double average = 0;
            foreach (int number in numbers)
            {
                average += number;
            }
            average /= numbers.Length;

            // Виведення елементів, які більші за середнє арифметичне
            Console.WriteLine("Елементи, які більші за середнє арифметичне:");
            foreach (int number in numbers)
            {
                if (number > average)
                {
                    Console.WriteLine(number);

                }
            }
        }
    }
}
