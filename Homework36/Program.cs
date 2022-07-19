// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

namespace Homework36
{
    class Programme
    {
        public static void Main()
        {
            int[] array = new int [4];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            SumElementsArray(array);
        }
        public static void FillArray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-10, 10);
            }
        }
        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static void SumElementsArray(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(i % 2 != 0) sum=sum + array[i];
            }
            Console.Write(sum);
        }
    }
}