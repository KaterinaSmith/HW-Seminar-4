// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadInt ("Введите число:");
int length = NumberLength(number);
SumNumbers (number, length);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index = index + 1;
    }
    return index;
}
void SumNumbers (int n, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /=10;
    }
    Console.WriteLine(sum);
}