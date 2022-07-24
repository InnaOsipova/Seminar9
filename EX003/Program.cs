// два числа a и b  и должно быть а в степени b

int StepenNamber (int a, int b)
{
    if (b <= 1) return a;
    return a * (StepenNamber(a, b-1));
}

System.Console.WriteLine(StepenNamber(2, 2));