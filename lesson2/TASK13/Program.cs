Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

int ParsFirstNumber(int a)
{
    int number = a/100;
    int number2 = number%10;
    return number2;
}

if (a > 99){
    int result = ParsFirstNumber(a);
    Console.WriteLine($"Третья цифра: {result}");
}
else
    Console.WriteLine($"Третьей цифры нет");
