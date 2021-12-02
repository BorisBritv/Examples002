// 41. Выяснить являются ли три числа сторонами треугольника 

bool A (int b,int c,int d )
{
   return ((b+c>d) && (b+d>c) && (c+d>b));
}

Console.WriteLine(A(15,15,9));