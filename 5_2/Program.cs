//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void SumNotEven()
{
    int[] Array = new int[new Random().Next(2, 15)];
    int length = Array.Length;
    int sum = 0;
    
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(-10, 11);
        if(index % 2 == 1)
        {
            sum = sum + Array[index];
        }
    }
    Console.WriteLine($"Первоначальный массив: [{String.Join(", ", Array)}]");
    Console.WriteLine($"Сумма чисел нечётных ппозиций массива: {sum}");
}
SumNotEven();