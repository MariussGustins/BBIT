using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[20, 20];
        Random rnd = new Random();

        // set array values and display them
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(1, 100);
                Console.Write($"{array[i, j],3} "); // space between arrays
            }
            Console.WriteLine();
        }

        int min = array[0, 0];
        int max = array[0, 0];

        // find largest and smallest in array
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        // smallest value
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Smallest value: {min}");
        Console.WriteLine("Coordinates of smallest value:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == min)
                {
                    Console.WriteLine($" [{i}, {j}] = {min}");
                }
            }
        }

        // largest value
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Largest value: {max}");
        Console.WriteLine("Coordinates of largest value:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == max)
                {
                    Console.WriteLine($" [{i}, {j}] = {max}");
                }
            }
        }

        Console.WriteLine("-----------------------");

        // sort array
        int[] sortedArray = new int[array.Length];
        int index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sortedArray[index++] = array[i, j];
            }
        }
        Array.Sort(sortedArray);

        
        Console.WriteLine("Sorted array:");
        index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = sortedArray[index++];
                Console.Write($"{array[i, j],3} "); 
            }
            Console.WriteLine();
        }
    }
}
