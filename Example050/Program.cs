// 50. В двумерном массиве n×k заменить четные элементы на противоположные


// int[] numbers(int N)
// {
//     int[] arr = new int[N];                 // создаю новый массив
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);  // заполняю значениями [0;9]
//     }
//     return arr;
// }


int[,] array (int n,int m)                                           // метод заполнения массива
{
    int[,] array = new int[n,m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
   return array;
}


string PrintArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result+=($"{array[i, j]} ");
        }
        
    }
  return result;
}


// string PrintArray(int[] arr)                   //метод печати массива с типом данных стринг,в качестве аргумента приходит массив.
// {
//     string result = string.Empty;            // создаем переменную с пустой строкой
//     for (int i = 0; i < arr.Length; i++)       // делаем перебор всех элементов массива
//     {
//         result += $"{ arr[i]} ";                  // кладем в созданную переменную все элементы массива 
//     }
//     return result;                              // возвращаем в метод все элементы массива.
// }


string NotEvenElements(int[,] array)
{

    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                result +=$" {(array[i, j] + 1)} ";

            }
            if (array[i, j] % 2 != 0)
            {
                result += $"{array[i, j]} ";
            }

        }

    }
    return result;
}





Console.WriteLine();

int[,] NewArr = array[4,5];
Console.Write(PrintArray(NewArr));
Console.WriteLine();
Console.Write(NotEvenElements(NewArr));


