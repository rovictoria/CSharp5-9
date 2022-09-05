// Программа, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Fun()
{
    Console.Write("Задайте k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Задайте b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Задайте k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Задайте b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine ($"Первое уравнение: y = {k1} * x + ({b1})");
    Console.WriteLine($"Второе уравнение: y = {k2} * x + ({b2})");

    // y = {k1}*x + b1; y = {k2}*x + b2
    // (b2-b1)= k1*x-k2*x
    // x = (b2-b1)/(k1-k2)

    if (k1 != k2)
    {
        double x = (b2-b1)/(k1-k2);
        double y = (k1 * x + b1);

        Console.WriteLine($"Точка пересечения ({Math.Round(x, 2)} ; {Math.Round(y,2)})");
    }
    
    else if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine($"Прямые параллельны, точек пересечения нет");
    }
    
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Прямые cовпадают");
    }
}

Fun();