// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void AverageValue(int[,] matr)
{
    double result;
    double sum; 

    for (int j = 0; j < matr.GetLength(1); j++) //4
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++) //3
        {
            sum = sum + matr[i, j];
        }
        result = sum / matr.GetLength(0);
        Console.WriteLine($"Среднее арифм. {j + 1} столбца = {Math.Round(result, 2)}");
    }
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
AverageValue(matrix);