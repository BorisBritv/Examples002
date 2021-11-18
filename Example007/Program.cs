// 7. Показать числа от -N до N

int[] A(int N)                                                // метод по созданию нового массива и заполнению его значениями 
{
    int[] arr = new int[N];                                   // создал новый массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-5,7);  // заполнил массив случайными значениями от минимального до максимального
    }
    return arr;
}



string PrintArray(int[]arr)                                    // метод с типом данных string в который приходит массив
{
    string res = string.Empty;                               
    for (int i = 0; i <arr.Length; i++)
    {
        res+=arr[i];                                           //  в res складываю значения массива который создавал в методе выше
    }
    return res;
}
int[] newArr= A(8);                                            // создал новый массив чтобы положить в него метод с длинной массива
Console.Write(PrintArray(newArr));
