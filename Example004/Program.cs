// 4. Найти максимальное из трех чисел

int Max(int a,int b,int c)                    
{
    int max = a;                         // создал переменную max и в нее положил первый аргумент приходящий в метод
    if(b>max){max=b;}                    // поочердено сравнил второй и третий аргумент с max.
    if(c>max){max=c;}
    return max;
}

Console.WriteLine(Max(300,5445,76));