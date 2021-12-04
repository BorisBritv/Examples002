//66.Показать натуральные числа от 1 до N, N задано

string A(int N)
{
    if (N == 1) return "1 ";
    else return $"{(A(N - 1) + N)} ";
}
    Console.WriteLine(A(8));

    
// int N = 8;
// for (int i = 1; i < N; i++)
// {

// }


