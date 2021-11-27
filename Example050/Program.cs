// 50. В двумерном массиве n×k заменить четные элементы на противоположные

void FillArray(int[,] array)                                           // метод заполнения массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }

}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}





void NotEvenElements(int[,] array)
{
    int f = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                f = (array[i, j] + 1);
                Console.Write(f+" ");
            }
            if (array[i, j] % 2 != 0)
                Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }

}

int[,] array = new int[4, 5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

NotEvenElements(array);