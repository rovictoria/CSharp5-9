// Массив, заполненный случайными
// положительными трёхзначными числами. 
// Программа, которая покажет количество чётных чисел в массиве.

void CountEven()
{
    int[] Array = new int[new Random().Next(2, 15)];
    int length = Array.Length;
    int count = 0;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(100, 1000);
        if (Array[index] % 2 == 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Первоначальный массив: [{String.Join(", ", Array)}]");

    if (count == 0)
    {
        Console.WriteLine($"Чётных чисел в этом массиве нет");
    }
    else
    {
        Console.WriteLine($"Чётных чисел в этом массиве: {count}");
    }
}

CountEven();



// Если без доп. условия есть/нет:
// void CountEven1()
// {
//     int[] Array = new int[new Random().Next(2, 15)];
//     int length = Array.Length;
//     int count = 0;
//     for (int index = 0; index < length; index++)
//     {
//         Array[index] = new Random().Next(100, 1000);
//         if (Array[index] % 2 == 0)
//         {
//             count++;
//         }
//     }

//     Console.WriteLine($"Первоначальный массив: [{String.Join(", ", Array)}]");
//     Console.WriteLine($"Чётных чисел в этом массиве: {count}");
    
// }

// CountEven1();