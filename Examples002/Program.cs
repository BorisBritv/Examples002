﻿// 1. По двум заданным числам проверять является ли первое квадратом второго

bool c(int a, int b)                       // создаю метод с типом данных bool,аргументами метода являются два значения с типом данных int 
{
    if (a == b * b)                        // проверяю равен ли первое значение квадратом второго. 
    {
       return true;
    }
        return false;
}
Console.WriteLine(c(36, 7));