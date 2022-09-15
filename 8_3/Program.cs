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

void NewMatrix(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
      int size;
      if (matr1.GetLength(0) > matr1.GetLength(1)) size = matr1.GetLength(0);
      else size = matr1.GetLength(1);

      int[,] matr3 = new int[size, size];

      Console.WriteLine("Результирующая матрица:");
      for (int i = 0; i < matr2.GetLength(0); i++)
      {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
          for (int k = 0; k < matr1.GetLength(1); k++)
          {
            matr3[i, j] = matr3[i, j] + matr1[i, k] * matr2[k, j];
          }
          Console.Write($"{matr3[i, j]}  ");
        }
        Console.WriteLine();
      }
    }
    else 
    {
      Console.WriteLine("Умножение невозможно.");
      Console.WriteLine("Введите другие размерности матриц, чтобы кол-во столбцов 1 было = кол-ву  строк 2");
    }
}

    int[,] matrix1 = new int[2, 3];
    int[,] matrix2 = new int[3, 2];

    FillArrayRandom(matrix1);
    Console.WriteLine();
    FillArrayRandom(matrix2);
    Console.WriteLine();
    NewMatrix(matrix1, matrix2);
