// адайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

namespace Homework34
{
    class Programme
    {
        public static void Main()
        {
            int[] array = new int[10];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            CheckArrayElement(array);
        }
        public static void FillArray(int[] array)
        {
            for(int i=0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }
        }
        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static void CheckArrayElement(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)  count++;
            }
            Console.WriteLine($"Количество четных элементов в массиве - {count}");
        }
        
    }
}
