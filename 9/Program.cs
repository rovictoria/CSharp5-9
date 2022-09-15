// Ручной калькулятор на действие 

Console.WriteLine("Введите первое число: ");
double input1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите оператор (+, -, *, /)");
string input2 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
double input3 = Convert.ToDouble(Console.ReadLine());

double output = 0;

if (input2 == "*") output = input1 * input3;
else if (input2 == "/") output = input1 / input3;
else if (input2 == "-") output = input1 - input3;
else if (input2 == "+") output = input1 + input3;
else Console.Write("Что-то пошло не так: ");


Console.WriteLine($"{input1} {input2} {input3} = {output}");



// Программа, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
int SumOfNumbers(int num)
{
    if (num < 0) num *= -1; //или добавить общее усл-е if >= 0 (основное решение) else ; или условие добавить вне метода
    {
        if (num > 9) return (num % 10) + (SumOfNumbers(num / 10));
        else return num;
    }
}

Console.WriteLine($"Сумма цифр числа: {SumOfNumbers(222)}");
Console.WriteLine();


// Программа, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int NumberDegree(int m, int n)
{
    if (n > 0) return m * (NumberDegree(m, n-1));
    else
    {
        return 1;
    }
}

int a = -3;
int b = 3;
Console.WriteLine($"{a} в степени степени {b} = {NumberDegree(a,b)}");