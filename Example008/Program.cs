﻿// 8. Показать четные числа от 1 до N

string Chetnye(int N)                                 // создал метод с методом данных стринг который принимает число
{
string res = string.Empty;                           // создал переменную и положил в нее пустую строку
for (int i = 1; i <= N; i++)                          //  положил в цикл условие задачи
{
    if (i % 2 == 0)                                  // проверил каждое число на четность
    {
        res += $"{i  }  ";                           // в переменную res складываю каждое число удовлетворяющее проверке на четность
    }
}
     return res;
}
Console.WriteLine(Chetnye(8));


