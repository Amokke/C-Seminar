int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

    if(int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    {
        Console.WriteLine("Ввели не число. Повторите ввод!");
    }
}

return result;
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

int number = GetNumber("Введите число");
int len = NumberLen(number);
SumNumbers(number, len);