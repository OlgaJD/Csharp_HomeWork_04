// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void CreateNewArray()
{
    int[] array = new int[8];
    foreach (int i in array)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]}, ");
    }
}
CreateNewArray();

// В условии задачи не указано, какими числами задается массив. Для удобства взято от 1 до 99.
