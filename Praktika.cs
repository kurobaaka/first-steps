using System;

class Program
{
    static void Main()
    {
        // Значение x = 1.57
        double x1 = 1.57;
        double result1 = Math.Pow(x1, 5) - (10.15 - Math.Pow(x1, 2)) / Math.Pow(1 + x1, 2);
        Console.WriteLine($"Результат для x = {x1}: {result1:F3}");

        // Значение x = -2.5
        double x2 = -2.5;
        double result2 = Math.Pow(x2, 5) - (10.15 - Math.Pow(x2, 2)) / Math.Pow(1 + x2, 2);
        Console.WriteLine($"Результат для x = {x2}: {result2:F3}");
    }
}

////////////////////////////////////////////////////////////////////////////

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вес в фунтах: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        
        // 1 российский фунт = 0.4095 кг
        double kilograms = pounds * 0.4095;
        
        Console.WriteLine($"{pounds} фунтов = {kilograms:F3} килограммов");
    }
}

////////////////////////////////////////////////////////////////////////////

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int number = random.Next(100, 1000); // Генерация случайного трехзначного числа
        Console.WriteLine($"Случайное трехзначное число: {number}");

        int halvedNumber = number / 2; // Уменьшаем число в 2 раза
        Console.WriteLine($"Число, уменьшенное в 2 раза: {halvedNumber}");
    }
}
