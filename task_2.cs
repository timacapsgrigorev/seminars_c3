using System;

namespace SumOfElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем генератор случайных чисел
            Random random = new Random();

            // Задаем размер массива
            int arraySize = 10;

            // Создаем и заполняем массив случайными числами
            int[] numbersArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                numbersArray[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 99
            }

            // Выводим массив на экран
            Console.WriteLine("Сгенерированный массив:");
            foreach (int number in numbersArray)
            {
                Console.Write(number + " ");
            }

            // Находим сумму элементов, стоящих на нечетных позициях
            int sum = 0;
            for (int i = 1; i < arraySize; i += 2)
            {
                sum += numbersArray[i];
            }

            // Выводим сумму на экран
            Console.WriteLine("\n\nСумма элементов на нечетных позициях: " + sum);
        }
    }
}
