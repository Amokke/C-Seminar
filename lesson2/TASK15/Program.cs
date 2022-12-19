Console.WriteLine("Введите цифру дня недели: ");
int a = int.Parse(Console.ReadLine() ?? "0");



if (a < 1 || a > 7){
    Console.WriteLine($"Такого дня недели не существует");
}
else if (a > 0 && a < 6){
   Console.WriteLine($"Нет");
}
else
    Console.WriteLine($"Да");