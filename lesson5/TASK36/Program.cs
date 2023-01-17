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


int[] InitArray(int dimension, int rightBound, int leftBound)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
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


int SumNotEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0)
        sum += array[i];
    }
    return sum;
}


int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] arr = InitArray(dimensin, rightBound, leftBound);

PrintArray(arr);
int notEvenSum = SumNotEven(arr);
Console.WriteLine(notEvenSum);