// Показать натуральные числа от N до 1, N задано

string A(int b)
{
    if ((b > 1)) return $" {(b + A(b - 1))}";
     else return " 1";
}

Console.WriteLine(A(8));