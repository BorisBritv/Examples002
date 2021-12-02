// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("Введите число ");

int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();


int A(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.WriteLine(A(array));

