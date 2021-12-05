// 69. Найти сумму элементов от M до N, N и M заданы

int A(int M, int N)
{
    if (M == N) return N;
    if (M > N) return M + A(M - 1, N);
    else return M + A(M + 1, N);
}

Console.WriteLine(A(3, 3));