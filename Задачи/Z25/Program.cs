Z25();

void Z25()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    //3, 5 -> 243 (3⁵)
    //2, 4 -> 16

    Random random = new Random();
    int A = random.Next(2,13);
    int B = random.Next(2,6);

    Console.WriteLine($"{A}^{B} = {CustomPower(A, B)}");
}

int CustomPower(int A, int B)
{
    int MultProduct = 1;

    while (B > 0)
    {
        MultProduct *=A;
        B--;
    }
    return MultProduct;
}