//68.Показать натуральные числа от M до N, N и M заданы

// string A(int M, int N)
// {
//     if (M > N) return $" {( M + A(M - 1,N))} ";
//     else return $" {N}";
// }

// Console.WriteLine(A(4, 3));



string A(int M, int N)
{
    if (M==N) return $" {N}";
    if (M > N) return $" {( M + A(M - 1,N))} ";
    else return $" {( M + A(M + 1,N))} ";
}

Console.WriteLine(A(-3, 3)); 