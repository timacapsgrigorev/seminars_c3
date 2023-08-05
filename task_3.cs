using System;

namespace DifferenceBetweenMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем массив вещественных чисел
            double[] numbersArray = { 3.14, 2.71, 7.62, 1.618, 0.577, 4.669 };

            // Инициализируем переменные для хранения максимального и минимального значений
            double max = numbersArray[0];
            double min = numbersArray[0];

            // Находим максимальное и минимальное значения в массиве
            foreach (double number in numbersArray)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }
            }

            // Находим разницу между максимальным и минимальным значениями
            double difference = max - min;

            // Выводим результат на экран
            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Разница между максимальным и минимальным значениями: " + difference);
        }
    }
}
