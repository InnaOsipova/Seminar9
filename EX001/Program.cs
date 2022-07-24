string SeriesOfNumbers (int a, int n)
{
    if (a == n) 
    {
        return n.ToString(); 
    }
    else 
    {
        return a.ToString() + " " + SeriesOfNumbers(a+1 , n); 
    }
}

Console.Write(SeriesOfNumbers (1, 5));