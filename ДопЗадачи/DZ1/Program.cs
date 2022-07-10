//Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.

DZ1();

void DZ1()
{
    Random random = new Random();
    int number = random.Next(1, 101);
    Console.WriteLine($"Число: {number}");

    BinaryPalindromCheck(number);
}

void BinaryPalindromCheck(int number)
{
    int size = (Convert.ToString(number, 2)).Length;
    int[] binary = new int[size];
    int index = 0;
    
    for (int i = 0; i < binary.Length; i++)
    {
        if (number > 0)
        {
            binary[i] = number%2;
            number/=2;
        }
    }    
    Array.Reverse(binary);

    PrintArray(binary);

    while (index < binary.Length/2)
    {
        if (binary[index] != binary[binary.Length - 1 - index])
        {
            index = binary.Length;
        }
        else
        {
            index++;
        }
    }
    if (index== binary.Length)
    {
        Console.WriteLine("Не палиндром");
    }
    else
    {
        Console.WriteLine("Палиндром");
    }
}

void PrintArray(int[] binary)
{
        Console.WriteLine("Бинарная репрезентация");
    for (int i = 0; i < binary.Length; i++)
    {
        Console.Write(binary[i] + " ");
    }
    Console.WriteLine();
}