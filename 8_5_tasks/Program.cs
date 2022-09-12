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
    Console.WriteLine("Заданная матрица:");

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

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrixSecondTask = new int[5, 3];
FillArrayRandom(matrixSecondTask);
EachSum(matrixSecondTask);
Console.WriteLine();

FindMinSum(matrixSecondTask);
Console.WriteLine();
Console.WriteLine();

int SumRow(int[,] matr, int i)  //считает и возвращает значение суммы для заданной строки
{
    int sum = 0;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = sum + matr[i, j];
    }
    return sum;
}

void EachSum(int[,] matr)  //отдельно вывод суммы каждой строки для проверки
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма {i} строки {SumRow(matr, i)}.");
    }
}

void FindMinSum(int[,] matr)  //поиск строки с мин. суммой
{
    Console.WriteLine("Поиск строки с наименьшей суммой элементов:");
    int minIndex = 0;
    int minSum = SumRow(matr, 0);

    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        if (SumRow(matr, i + 1) < minSum)
        {
            minSum = SumRow(matr, i+1);
            minIndex = i+1;
        }
    }
    Console.WriteLine($"Строка с индексом {minIndex}: сумма = {minSum}.");

    for (int i = 0; i < matr.GetLength(0); i++)  //отдельно проверка на равенство с получившимся minSum
    {
        if (SumRow(matr, i) == minSum && minIndex != i) Console.WriteLine($"Строка с индексом {i} имеет ту же сумму.");
    }
}

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Нахождение произведения двух матриц");

void NewMatrix(int[,] matr1, int[,] matr2, int[,] matr3)
{
    Console.WriteLine("Результирующая матрица:");
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            matr3[i, j] = matr1[i, j] * matr2[i, j];
            Console.Write($"{matr3[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int m = 2; //ввожу внутри кода такие моменты, чтобы избежать доп.условий при вводе пользователем
int n = 3;

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] matrix3 = new int[m, n];

FillArrayRandom(matrix1);
Console.WriteLine();
FillArrayRandom(matrix2);
Console.WriteLine();
NewMatrix(matrix1, matrix2, matrix3);

Console.WriteLine();
Console.WriteLine();


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void AllInOne()
// {
//     int[,,] squareMatrix = new int[2,2,2];
//     Console.WriteLine("Заданная матрица:");

//     IEnumerator<int> randoms = Enumerable.Range(0, squareMatrix.Length).Shuffle().GetEnumerator();
//     randoms.MoveNext();

//     for (int i = 0; i < squareMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < squareMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < squareMatrix.GetLength(2); k++, randoms.MoveNext())
//             {
//             squareMatrix[i, j,k] = randoms.Current;

//             Console.Write($"{squareMatrix[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
        
//     }
// }
// AllInOne();
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine("Заполняю спирально матрицу и получаю:");
int[,] matrixSpir = new int[4, 4];

void FillArraySpiral(int[,] matr)
{
    int i = 0;
    int j = 0;
    int value = 1;

    while (value <= 16)     //если универсально - перемножение длин кол-вы строк и столбцов матрицы
    {
        matr[i, j] = value;
        value++;

        int maxIndexI = matr.GetLength(0) - 1;
        int maxIndexJ = matr.GetLength(1) - 1;

        if (i <= j + 1 && (i + j) < maxIndexJ) j++;     //по j вправо, исключая нахлест потом
        else if (i < j && (i + j) >= maxIndexI) i++;
        else if (i >= j && (i + j) > maxIndexJ) j--;
        else i--;
    }
}

FillArraySpiral(matrixSpir);
WriteNewMatrix(matrixSpir);