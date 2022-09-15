// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int Natural(int m, int n)
{
    if (m > 0 && n > 0 && m <= n)
    {
        Console.Write($"{m} ");
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + (Natural(m + 1, n));
        }
    }
    else
    {
        Console.WriteLine($"Введённые числа не удовлетворяют условию");
        return 0;
    }
}

Console.Write($"Порядок чисел: ");
Natural(2, 5);

Console.WriteLine();
Console.WriteLine();

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNatural(int m, int n)
{
    if (m > 0 && n > 0 && m <= n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + (SumNatural(m + 1, n));
        }
    }
    else
    {
        Console.WriteLine($"Введённые числа не удовлетворяют условию"); //это можно и вне метода сделать как в 3 задаче
        return 0;
    }
}

Console.WriteLine($"Сумма натуральных чисел в заданном промежутке: {SumNatural(1, 3)}");
Console.WriteLine();

// Программа вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int a, int b)
{
    if (a == 0) return (b + 1);
    else if (a > 0 && b == 0) return Akkerman(a - 1, 1);
    else if (a > 0 && b > 0) return Akkerman(a - 1, Akkerman(a, b - 1));
    else
    {
        // Console.WriteLine("Введите неотрицательные числа m и n, расчёт с вашими данными невозможен"); МОЖНО ДОБАВИТЬ если убрать условие if else вне метода
        return 0;
    }
}

int m = 3;
int n = 2;

// Если убрать это, то оставить только Console.WriteLine(Akkerman(m, n));
if (m >= 0 && n >= 0) Console.WriteLine($"Результат функции Аккермана для заданных (m, n): {Akkerman(m, n)}");
else Console.WriteLine("Введите неотрицательные числа m и n, расчёт с вашими данными невозможен");


Console.WriteLine();
//если учесть, что для n>3 или m>3 можно прописать что результат выходит за рамки отображаемого или прописать с множителем,
//но это будет примерное значение поэтому проще и так получить ошибку от самой программы