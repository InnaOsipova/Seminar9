// возвращает сумму цифр числа

int SumNumbers (int n)
{
    if (n == 0) return 0;
    return n % 10 + SumNumbers (n / 10);
}

Console.WriteLine(SumNumbers(56));