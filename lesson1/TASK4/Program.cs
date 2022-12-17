Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine() ?? "0");



if (a > b && a > c) {
    Console.WriteLine($"Наибольшее число {a}");
}
//Если a и b равны то вторым условием выведет их значение
else if (b > c) { 
    Console.WriteLine($"Наибольшее число {b}");
}
//Если b и c равны третье условие выведет их значение
//В случае если все числа равны все равно значение будет выведено третим условием
else 
    Console.WriteLine($"Наибольшее число {c}");
