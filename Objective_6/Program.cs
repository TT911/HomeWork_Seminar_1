// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());

if (number %2 != 0 )
{
    Console.WriteLine($"{number} нечетное");
}
else
{
    Console.WriteLine($"{number} четное");
}
 Console.WriteLine("Задача выполнена!");