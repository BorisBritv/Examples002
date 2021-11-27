// 49. Показать двумерный массив размером m×n заполненный вещественными числами

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


int m=6;
int n = 5;

int[,] array = new int [ m, n ];



FillArray(array);

PrintArray(array);