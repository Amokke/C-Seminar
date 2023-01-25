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

void FindIndex(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) 
    {
        Console.WriteLine(array[row, column]);
    }
    else Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
}

int row = GetNumber("Введите ряд");
int column = GetNumber("Введите столбец");

int rows = 3;
int columns = 4;
int leftBound = 1;
int rightBound = 9;

int[,] arr = InitArray(rows, columns, leftBound, rightBound);

PrintArray(arr);
FindIndex(arr, row, column);