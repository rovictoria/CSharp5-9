// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



void MyArray()
{
    Console.Write("Задайте количество чисел, которое хотите ввести: ");
    int M = Convert.ToInt32(Console.ReadLine());
    
    if (M > 1)
    {
        int count = 0;

        int[] arr = new int[M];

        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] > 0)
            {
                count++;
            }
        }
        
        Console.WriteLine($"Заданный массив: [{String.Join(", ", arr)}]");
        Console.WriteLine($"Длина массива: {M}.");
        Console.WriteLine($"Элементов, больших нуля: {count}.");
    }
    else 
    {
        Console.WriteLine("Вы не можете создать массив такой размерности, попробуйте ещё раз :)");
    }
}

MyArray();