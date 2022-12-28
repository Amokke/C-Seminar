string GetNumber(string message)
{
    int number = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out number) && number > 9999 && number < 100000)
        {
            
            break;
        }
        else
        {
            Console.WriteLine("Введено не пятизначное число");
        }
    }
    string result = number.ToString();
    return result;
}

string testnumber = GetNumber("Введите пятизначное число.");
int len = testnumber.Length;

if (testnumber[0] == testnumber[4] && testnumber[1] == testnumber[3])
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}
