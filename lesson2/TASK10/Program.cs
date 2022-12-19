Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

int ParsNumber(int a)
{
    int number = a/10;
    int number2 = number%10;
    return number2;
}

if (a < 1000 && a > 99){
    int result = ParsNumber(a);
    Console.WriteLine($"Вторая цифра: {result}");
}
else
    Console.WriteLine($"Введено не трехзначное число");
