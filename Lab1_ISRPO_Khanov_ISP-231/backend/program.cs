// Console.WriteLine("Hello, World!");
// Console.WriteLine("Меня зовут Ханов В.В.");
// Console.WriteLine(DateTime.Now);
Console.WriteLine();
Console.Write("Введите имя: ");
var name = Console.ReadLine();
Console.WriteLine($"Привет, {name}");
Console.WriteLine();
string dayOfWeek = DateTime.Now.ToString("dddd");
Console.WriteLine($"Текущий день недели: {dayOfWeek}");
Console.WriteLine();
Console.Write("Хотите продолжить? (y/n): ");
string answer = Console.ReadLine()?.ToLower();
if (answer == "y")
{
    Console.WriteLine("Продолжаем");
}
else if (answer == "n")
{
    Console.WriteLine("Завершение работы...");
    Console.WriteLine("Работа завершена");
}
else
{
    Console.WriteLine("Неверный ввод");
}