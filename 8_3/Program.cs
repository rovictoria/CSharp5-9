// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

Console.WriteLine("Нахождение произведения двух матриц");

void NewMatrix(int[,] matr1, int[,] matr2, int[,] matr3)
{
  Console.WriteLine("Результирующая матрица:");
  for (int i = 0; i < matr3.GetLength(0); i++)
  {
    for (int j = 0; j < matr3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matr1.GetLength(1); k++)
      {
        sum = sum + matr1[i,k] * matr2[k,j];
      }
      matr3[i,j] = sum;
      Console.Write($"{matr3[i, j]}  ");
    }
    Console.WriteLine();
  }
}

int m = 3; //ввожу внутри кода такие моменты, чтобы избежать доп.условий при вводе пользователем
int n = 3;

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] matrix3 = new int[m, n];

FillArrayRandom(matrix1);
Console.WriteLine();
FillArrayRandom(matrix2);
Console.WriteLine();
NewMatrix(matrix1, matrix2, matrix3);
