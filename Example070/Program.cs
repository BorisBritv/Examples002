//70.Найти сумму цифр числа

int A(int b)
{
    if (b / 10 == 0) return b;
    else return A(b % 10) + A(b / 10);
}

Console.WriteLine(A(113));