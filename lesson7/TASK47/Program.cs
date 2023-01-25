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


double[,] InitArray(int row, int column, int leftBound, int rightBound)
{
    double[,] result = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            result[i, j] = Math.Round(rnd.Next(leftBound, rightBound) + rnd.NextDouble(), 1);
    }
    return result;
}

//метод для печати массива
void PrintArray(double[,] array)
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




int rows = GetNumber("Введите количество строк массива");
int columns = GetNumber("Введите количество столбцов массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
double[,] arr = InitArray(rows, columns, leftBound, rightBound);

PrintArray(arr);