Z27();

void Z27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    //452 -> 11
    //82 -> 10
    //9012 -> 21

    Random random = new Random();
    int number = random.Next(100,10001);

    Console.WriteLine($"Сумма цмфр числа {number} = {DigitSum(number)}");
}

int DigitSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number%10;
        number/=10;
    }
    return sum;
}