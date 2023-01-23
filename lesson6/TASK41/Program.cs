string GetString(string message)
{
    string result = "";
    Console.WriteLine(message);
    result = Console.ReadLine();
    return result;
}

int NumberPlus(string data)
{
    var array = data.Split(',');

    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i]) > 0) result++;
    }
    return result;
}

string data = GetString("Введите M чисел через запятую");
Console.WriteLine($"Чисел больше нуля: {NumberPlus(data)}");