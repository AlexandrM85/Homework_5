// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("--------------Задача №34.--------------");
int[] ar = GetArray(7, 100, 999);
Console.WriteLine(String.Join(", ", ar));
Console.WriteLine($"В данном массиве кол-во четных чисел = {FindEvenNumbers(ar)}");

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("--------------Задача №36.--------------");
int[] arr = GetArray(6, -100, 100);
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine($"Сумма элементов на нечетных позициях = {SumOddNumber(arr)}");

int SumOddNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("--------------Задача №38.--------------");
int[] array = GetArray(5, 1, 1000);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifferenceMinMax(array)}");

int DifferenceMinMax(int[] a)
{
    int min = a[0];
    int max = a[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }
    int diff = max - min;
    return diff;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
