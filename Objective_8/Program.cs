// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());
int n = 2;

while (n <= number)
{
    Console.Write(n);
    if (n != number) Console.Write(", ");
    n = n+2;
}
Console.WriteLine(" ");
Console.WriteLine("Задача выполнена!");