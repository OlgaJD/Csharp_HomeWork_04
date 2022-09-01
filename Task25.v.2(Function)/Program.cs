// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень будем его возводить: ");
int y = Convert.ToInt32(Console.ReadLine());

int Degree(int x, int y)
{
    int res = 1;                  // можно брать res = x;
    for (int i = 1; i <= y; i++)  // тогда в for(i<y) (изначально x уже будет входит в результат)
    {
        res *= x;
    }
    return res;
}
Console.WriteLine($"Число {x} степени {y} будет равно {Degree(x, y)}");