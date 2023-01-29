int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
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

int NaturalSumMN(int m, int n)
{
    if (m == n)
        return n;
    else if (m > n)
        return 0;
    return n + NaturalSumMN(m, n - 1);
}

int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} = {NaturalSumMN(m, n)}");