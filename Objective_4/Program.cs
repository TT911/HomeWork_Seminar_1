//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье целое число:");
int number3 = int.Parse(Console.ReadLine());

if ((number1 > number2) && (number1 > number3))
    {
        Console.WriteLine($"Максимальное число {number1}");
    }     
    else if ((number2 > number1) && (number2 > number3))
    {
        Console.WriteLine($"Максимальное число {number2}");
    }
    else if ((number3 > number1) && (number3 > number2))
    {
        Console.WriteLine($"Максимальное число {number3}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {number1}"); //если три числа одинаковые
    }

    Console.WriteLine("Задача выполнена!");