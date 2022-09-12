// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrixSpir = new int[4, 4];

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
