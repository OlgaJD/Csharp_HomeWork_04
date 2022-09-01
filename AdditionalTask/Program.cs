// Написать программу сортировки массива от большего к меньшему.
// Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.

Console.WriteLine("Write number");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void sort(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        int max = i;
        for (int j = i + 1; j < n; j++)
        {
            if (array[j] > array[max]) max = j;
        }

        int temp = array[i];
        array[i] = array[max];
        array[max] = temp;
        Console.Write($"{array[i]}, ");
    }

}
sort(array);
