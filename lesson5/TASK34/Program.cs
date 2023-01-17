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


int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(100, 999);
    }
    return result;
}


void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        count++;
    }
    return count;
}


int dimensin = GetNumber("Введите размерность массива");
int[] arr = InitArray(dimensin);

PrintArray(arr);
int evenNumbers = CountEven(arr);
Console.WriteLine(evenNumbers);