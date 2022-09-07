// Задаёт двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matr[i,j] = Math.Round((rand.NextDouble() + new Random().Next(-10, 11)), 1);
            Console.Write($"{matr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[3, 4];
FillArray(matrix);
