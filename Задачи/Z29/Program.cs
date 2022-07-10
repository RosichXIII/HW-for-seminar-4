Z29();

void Z29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
    //-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
    //6, 1, -33 -> [1, 6, -33]

    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    SortArray(array);
    PrintArray(array);
}

void FillArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    int temp;

    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j+1]))
            {
                temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
}