// Находит произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Первоначально через длины строила условия и код выглядил чуть короче, так как не прописывала запятые
// Но решила работать через индексы, так удобнее было добавить условия с запятыми 

void NewMas()
{
    int[] MyArr = new int[new Random().Next(2,11)];
    int maxindex1 = MyArr.Length-1;

    int[] NewArr = new int[((maxindex1 + 1) / 2) + ((maxindex1 + 1) % 2)] ;
    int maxindex2 = NewArr.Length-1;

    for(int index = 0; index <= maxindex1; index++)
    {
        MyArr[index] = new Random().Next(1,10);
    }

    Console.WriteLine($"Первоначальный массив: [{String.Join(", ", MyArr)}]");
    Console.Write($"Полученный массив [");

    if()
    for (int i = 0; i < ((maxindex1 + 2)/ 2 ); i++)
    {
        NewArr[i] = MyArr[i] * MyArr[maxindex1 - i];
        Console.Write($"{NewArr[i]}, ");
    }

    if (maxindex2 % 2 == 0)
    {
        NewArr[maxindex2] = MyArr[maxindex1 / 2 ];
        Console.Write($"{NewArr[maxindex2]}]");
    }
    else
    {
        NewArr[maxindex2] = MyArr[maxindex1 / 2 ] * MyArr[(maxindex1 / 2) + 1];
        Console.Write($"{NewArr[maxindex2]}]");
    }


}

NewMas();
