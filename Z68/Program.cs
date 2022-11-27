Console.WriteLine("Введите первое число");
uint M;
while (!uint.TryParse(Console.ReadLine()!, out M) || M <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите первое число");
}

Console.WriteLine("Введите второе число");
uint N;
while (!uint.TryParse(Console.ReadLine()!, out N) || N <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
}

uint Akk(uint n, uint m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Akk(n - 1, 1);
    else return Akk(n - 1, Akk(n, m - 1));
}

Console.WriteLine();
Console.Write($"A({M},{N}) = " + Akk(M, N));
Console.WriteLine();

