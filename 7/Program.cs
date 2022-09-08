// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m + n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
FillArray(matrix);


Console.WriteLine();
Console.WriteLine();

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

void FillArrayRandom(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ChangeMatrixElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 &&
                j > 0 && j % 2 == 0) matr[i, j] = matr[i, j] * matr[i, j];
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] newMatrix = new int[5, 5];
Console.WriteLine("Первоначальный массив:");
FillArrayRandom(newMatrix);

Console.WriteLine("Массив, полученный после замены:");
ChangeMatrixElements(newMatrix);

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12















// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 11);
//             Console.Write($"{matr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// void AverageValue(int[,] matr, int j)
// {
//     double result;
//     double sum;
//     sum = 0;

//     for (int i = 0; i < matr.GetLength(0); i++) //3
//     {
//         sum = sum + matr[i, j];
//     }

//     result = sum / matr.GetLength(0);
//     Console.Write($"{result} ");
//     j++; 

//     while(j < matr.GetLength(0))
//     {
//     AverageValue(matr, j);
//     }
// }


// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// AverageValue(matrix, 0);
