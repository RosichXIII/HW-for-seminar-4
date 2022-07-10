//Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99.
//Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все.

DZ3();

void DZ3()
{
    Random random = new Random();
    int size = 100;
    int[] arr = new int[size];
    int[] counts = new int [size];
    int max = 0;

    Console.WriteLine("Массив");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, size);
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("Массив счётчиков");
    for (int i = 0; i < counts.Length; i++)
    {
        counts[i] = 0;
        Console.Write(counts[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("Заполненные счётчики");
    for (int i = 0; i < arr.Length; i++)
    {
        counts[arr[i]]++;
    }
    for (int i = 0; i < counts.Length; i++)
    {
        Console.Write(counts[i] + " ");
    }

    for (int i = 0; i < counts.Length; i++)
    {
        if (counts[i] > max)
        {
            max = counts[i];
        }
    }
    Console.WriteLine();
    for (int i = 0; i < counts.Length; i++)
    {
        if (max == counts[i])
        {
            Console.WriteLine($"{i} встречается {max} раз(а)");
        }
    }
}