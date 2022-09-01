// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
void Sum()
{
    int y = 0;
    while (x > 0)
    {
        y = y + x % 10;
        x = x / 10;
    }
    Console.WriteLine(y);
}
Sum();
