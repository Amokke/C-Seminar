string GetString(string message)
{
    string result = "";
    Console.WriteLine(message);
    result = Console.ReadLine();
    return result;
}

int[] Array(string data)
{
    var array = data.Split(',');
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = int.Parse(array[i]);
        Console.Write(array[i] + " ");
    }
    return result;
}

string data = GetString("Введите 8 чисел через запятую");
Console.Write("Элименты введенного массива:");
Array(data);

