// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

namespace Homework38
{
    class Programme
    {
        public static void Main()
        {
            int[] array = new int [5];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            int max = MaxElementsArray(array);
            Console.WriteLine($"Maximum value is - {max}");
            int min = MinElementsArray(array);
            Console.WriteLine($"Minimum value is - {min}");
            int diff = max - min;
            Console.WriteLine($"Difference betweem {max} and {min} is {diff}");
;        }
        public static void FillArray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 101);
            }
        }
        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static int MaxElementsArray(int[] array)
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > max) max=array[i];
            }
            return max;
           
        }
        public static int MinElementsArray(int[] array)
        {
            int min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i]< min) min=array[i];
            }
            return min;
            
        }
    }
}