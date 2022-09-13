// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrSquare = new int[2, 2, 2];
AllForDifElements(matrSquare);

void AllForDifElements(int[,,] matr)
{
    int lengthArray = matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2);
    int[] myArray = new int[lengthArray];  //перемножила длины трёхмерного массива

    myArray[0] = new Random().Next(10, 100);
    int value;

    for (int i = 1; i < lengthArray; i++)
    {
        value = new Random().Next(10, 100);

        for (int j = 0; j < i; j++)
        {
            while (myArray[i] == myArray[j])
            {
                myArray[i] = new Random().Next(10, 100);
                j = 0;
                value = myArray[i];
            }
            value = myArray[i];
        }
    }


    Console.WriteLine("Заданная матрица:");
    int index = 0;

    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                matr[x, y, z] = myArray[index];
                index++;
                Console.Write($"{matr[x, y, z]} ({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}