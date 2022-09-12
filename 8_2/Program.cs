// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Первый способ решения задачи, без обращения к методу в каждом i

int[,] matrixSecondTask = new int[5, 3];
FillArrayRandom(matrixSecondTask);
EachSum(matrixSecondTask);
FindMinSum(matrixSecondTask);

void FillArrayRandom(int[,] matr)
{
    Console.WriteLine("Заданная матрица:");

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-5, 6);
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int SumRow(int[,] matr, int i)
{
    int sum = 0;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = sum + matr[i, j];
    }
    return sum;
}

void EachSum(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма {i} строки {SumRow(matr, i)}.");
    }
}

void FindMinSum(int[,] matr)
{
    Console.WriteLine("Поиск строки с наименьшей суммой элементов:");
    int minIndex = 0;
    int minSum = SumRow(matr, 0);

    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        if (SumRow(matr, i) <= SumRow(matr, i + 1))
        {
            minSum = SumRow(matr, i);
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с индексом {minIndex}: сумма = {minSum}.");

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (SumRow(matr, i) == minSum && minIndex != i) Console.WriteLine($"Строка с индексом {i} имеет ту же сумму.");
    }
}
