// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] squareMatrix = new int[2, 2, 2];
AllInOne(squareMatrix);



void AllInOne(int[,,] matr)
{
    Console.WriteLine("Заданная матрица:");

    for (int i = 0; i < squareMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < squareMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < squareMatrix.GetLength(2); k++)
            {
                squareMatrix[i, j, k] = new Random().Next(10, 100); ;

                Console.Write($"{squareMatrix[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}


// void CreateArray(int[,,] matr) //создаю одномерный массив из полученных значений
// {
//     int[] array = new int[8];  //перемножила длины трёхмерного массива
//     int value = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10, 100);
//         value = array[i];

//         for (int j = i + 1; j < array.Length; i++)
//         {
//             while(array[i] == array[j])
//             {
//                array[i] = new Random().Next(10, 100); 
//                j = 0
//             }
//         }
//     }

//     Console.WriteLine(String.Join(", ", array));
// }

// CreateArray();