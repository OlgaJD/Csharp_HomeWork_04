// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

try
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("В какую степень будем его возводить? ");
    int y = Convert.ToInt32(Console.ReadLine());

    void Degree()
    {
        int a = (int)Math.Pow(x, y);
        Console.WriteLine($"Число {x} в степени {y} будет равно {a}");
    }
    Degree();
}
catch
{
    Console.WriteLine("Вводите тольцо целые числа");
}
