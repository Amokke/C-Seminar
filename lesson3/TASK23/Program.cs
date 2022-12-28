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


int number = GetNumber("Введите число");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
