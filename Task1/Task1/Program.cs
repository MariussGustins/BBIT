int[,] array = new int[20,20];

Random rnd = new Random();

//array 20 by 20

for (int i = 0; i < array.GetLength(0) ; i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[i, j] = rnd.Next(1, 100);
        Console.WriteLine("[{0}, {1}] = {2}", i, j , array[i, j]);
    }
}

int min = array[0,0];

int max = array[0,0];
//smallest value in array and biggest value

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (min > array[i, j])
        {
            min = array[i, j];
        }else if(max < array[i, j])
        {
            max = array[i, j];
        }
    }
}
Console.WriteLine("-----------------------");
Console.WriteLine($"Smallest value: {min}, biggest value: {max}");
Console.WriteLine("-----------------------");


//finding coordinates for smallest value 

Console.WriteLine("Coordinates of smallest value: ");
for (int i = 0;i < array.GetLength(0); i++)
{
    for(int j = 0;j < array.GetLength(0); j++)
    {
        
        if (array[i, j] == min)
        {
            
            Console.WriteLine($" [{i}, {j}] = {min}");
        }
    }
}

Console.WriteLine("-----------------------");
//finding coordinates for largest value
Console.WriteLine("Coordinates of largest value: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (array[i, j] == max)
        {
            
            Console.WriteLine($" [{i}, {j}] = {max}");
        }
    }
}

Console.WriteLine("-----------------------");

//sorting array

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0) - 1; j++)
    {
        for (int k = 0; k < array.GetLength(0) - 1; k++)
        {
            if (array[i, k] > array[i, k + 1])
            {
                int tempValue = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = tempValue;

            }
        }
    }
}

//displaying sorted array

for (int i = 0;i < array.GetLength(0); i++)
{
    Console.WriteLine($"{i} :");
    for(int j = 0;j < array.GetLength(0); j++)
    {
        
        Console.WriteLine($"{array[i, j]}");
    }
}