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

int[,] InitArray(int rows, int columns, int leftBound, int rightBound)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            result[i, j] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] firstarray, int[,] secondarray, int rows, int columns)
{
    int[,] resultarray = new int[rows, columns];
    for (int i = 0; i < firstarray.GetLength(0); i++)
    {
        for (int j = 0; j < secondarray.GetLength(1); j++)
        {
            resultarray[i, j] = 0;
            for (int k = 0; k < firstarray.GetLength(1); k++)
            {
                resultarray[i, j] += firstarray[i, k] * secondarray[k, j];
            }
        }
    }
    return resultarray;
}

int rows = GetNumber("Введите размер матрицы");
int columns = rows;
int leftBound = GetNumber("Введите левую границу значений в матрице");
int rightBound = GetNumber("Введите правую границу значений в матрице");

int[,] firstarr = InitArray(rows, columns, leftBound, rightBound);
int[,] secondarr = InitArray(rows, columns, leftBound, rightBound);

PrintArray(firstarr);
Console.WriteLine();
PrintArray(secondarr);
int[,] resultarray = MatrixMultiplication(firstarr, secondarr, rows, columns);
Console.WriteLine();
PrintArray(resultarray);