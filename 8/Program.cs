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
            int maxPosition = j;

            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, j]) maxPosition = k;
            }

            int newNumber = matr[i, j];
            matr[i, j] = matr[i, maxPosition];
            matr[i, maxPosition] = newNumber;

         Console.Write($"{matr[i, j]}  ");
         }
    Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];

FillArrayRandom(matrix);
Console.WriteLine();

SystemFromMaxToMin(matrix);
Console.WriteLine();
