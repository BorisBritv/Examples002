// 43. Написать программу преобразования десятичного числа в двоичное

double A(int N)
{
    int mod = 0;
    double d = 0;
    for (int i = 0; N > 0; i++)
    {
        mod = N % 2;                                 // oстаток от деления
        N = (N - mod) / 2;                           // 
        d += mod * Math.Pow(10, i);                  
    }
    return d;
}

Console.WriteLine(A(2));