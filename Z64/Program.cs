Console.WriteLine("Введите число");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите число");
}

int c = 1;

void NumbersRec(int n, int a)
{
    if (a < n) NumbersRec(n, a + 1);
    if (a==n) Console.Write($"{a}");
    else Console.Write($", {a}");
}

Console.WriteLine();
NumbersRec(N, c);
Console.WriteLine();
