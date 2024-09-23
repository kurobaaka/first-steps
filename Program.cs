Console.Write("введите свое имя: ");
var name = Console.ReadLine();
 switch (name)
 {
    case "Федя":
    Console.WriteLine("Привет легенда");
    break;
 }
 Console.WriteLine("Привет, " + name);

 Console.Write("введите свой возраст: ");
 int age;
 if (int.TryParse(Console.ReadLine(), out age))
 {
    if (age >= 18 && age <= 65)
    {
        Console.WriteLine("Вы в возрасте от 18 до 65 лет");
    }
    else
    {
        Console.WriteLine("Вы не достигли 18 лет или превысили 65 лет");
    }
 }