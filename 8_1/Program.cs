int[,] matrix = new int[3, 4];

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArrayRandom(int[,] matr)
{
    Console.WriteLine("Неотсортированная матрица:");

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

void SystemFromMaxToMin(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < (matr.GetLength(1) - 1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int newNumber = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = newNumber;
                }
            }
        }
    }
}


void WriteNewMatrix(int[,] matr)
{
    Console.WriteLine("Упорядоченная матрица:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < (matr.GetLength(1)); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

FillArrayRandom(matrix);
Console.WriteLine();

SystemFromMaxToMin(matrix);

WriteNewMatrix(matrix);
Console.WriteLine();