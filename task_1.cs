
using System;

namespace CountEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем генератор случайных чисел
            Random random = new Random();

            // Задаем размер массива
            int arraySize = 10;

            // Создаем и заполняем массив случайными положительными трехзначными числами
            int[] numbersArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                numbersArray[i] = random.Next(100, 1000);
            }

            // Выводим массив на экран
            Console.WriteLine("Сгенерированный массив:");
            foreach (int number in numbersArray)
            {
                Console.Write(number + " ");
            }

            // Считаем количество четных чисел
            int evenCount = 0;
            foreach (int number in numbersArray)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            // Выводим количество четных чисел на экран
            Console.WriteLine("\n\nКоличество четных чисел: " + evenCount);
        }
    }
}
