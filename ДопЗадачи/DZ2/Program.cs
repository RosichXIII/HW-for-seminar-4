//Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
//Размер массива должен совпадать с квадратом количества единиц в нём.

DZ2();

void DZ2()
{
    Random random = new Random();
    int ones = random.Next(1, 11);
    int size = ones*ones;
    int[] array = new int[size];

    while (ones > 0)
    {
        ones--;
        int i = random.Next(0, size);
        if (array[i] !=1)
        {
            array[i] = 1;
        }
        else
        {
            ones++;
        }
    }

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != 1)
        {
            array[j] = 0;
        }
    }

    Console.WriteLine("Массив");
    for (int k = 0; k < array.Length; k++)
    {
        Console.Write(array[k] + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Размер массива: {size}");
    Console.WriteLine($"Кол-во единиц: {Math.Sqrt(size)}");
}
