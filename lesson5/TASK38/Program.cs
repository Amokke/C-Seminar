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


double[] InitArray(int dimension, int rightBound, int leftBound)
{
    double[] result = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = Math.Round(rnd.Next(leftBound, rightBound) + rnd.NextDouble(), 2);
    }
    return result;
}

void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


(double, double) MinMaxNumbers(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}


int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
double[] arr = InitArray(dimensin, rightBound, leftBound);

PrintArray(arr);
(double max, double min) = MinMaxNumbers(arr);
Console.WriteLine($"Максимальное число = {max}, минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом ровна: {Math.Round(max - min, 2)}");