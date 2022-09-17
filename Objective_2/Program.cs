//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    {
        Console.WriteLine($"{number1} > {number2}");
    }
    else if (number1 < number2)
    {
        Console.WriteLine($"{number2} > {number1}");
    }
    else
    {
        Console.WriteLine($"{number1} = {number2}");
    }

Console.WriteLine("Задача выполнена!");