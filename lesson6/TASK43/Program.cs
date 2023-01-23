double GetNumber(string message)
{
    double result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
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

(double, double) MinMaxNumbers(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (-b2 + b1) / (-k1 + k2);
    y = k2 * x + b2;
    return (x,y);
}


double b1 = GetNumber("Введите первую точку, первой прямой");
double k1 = GetNumber("Введите вторую точку, первой прямой");
double b2 = GetNumber("Введите первую точку, второй прямой");
double k2 = GetNumber("Введите вторую точку, второй прямой");
(double x, double y) = MinMaxNumbers(b1,k1,b2,k2);
Console.WriteLine($"Линии пересекутся в точке [{Math.Round(x,2)} ; {Math.Round(y,2)}]");
