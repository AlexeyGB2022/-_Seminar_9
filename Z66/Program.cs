Console.WriteLine("Введите первое число");
int M;
while (!int.TryParse(Console.ReadLine()!, out M) || M <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите первое число");
}

Console.WriteLine("Введите второе число");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите второе число");
}

int Sum = 0;

void NumbersSumRec(int m, int n)
{
    if (m <= n)
    {   
        Sum = Sum + m;
        NumbersSumRec(m+1, n);  
    } 
    if (m>n) Console.Write($"Сумма натуральных чисел в промежутке от {M} да {N} : {Sum}");
}

Console.WriteLine();
if (M<N) NumbersSumRec(M, N);
if (M>N) NumbersSumRec(N, M);
Console.WriteLine();

