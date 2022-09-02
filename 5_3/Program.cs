// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void MaxMin()
{
    Console.WriteLine("Задайте длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    double[] Array = new double[length];
    Random rand = new Random();
    int index = 0;   //необходимость в случае с массивом, если задать потом в for и сослаться на Array[0], обнуляет 1 элемент

    double max = Array[index];
    double min = Array[index];

    Console.WriteLine("Вывод массива: ");

    while (index < Array.Length)
    {
        Array[index] = Math.Round((rand.NextDouble() + new Random().Next(-20, 21)), 2);

        if (Array[index] > max) max = Array[index];  
        if (Array[index] < min) min = Array[index];
        index++;
    }

    Console.WriteLine($"Заданный массив: [{String.Join(", ", Array)}]");

    double difference = Math.Round((max - min),2);
    Console.WriteLine($"Разницу между макс. и мин. элементами массива   {difference}");
}

MaxMin();