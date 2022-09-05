// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] arr = new int [5];

void RandomArray(int[]array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(-100,100);
        arr[i] = value;
        Console.WriteLine($"{arr[i]} ");
    }
}

void GetDiffMaxMinNum(int[] array)
{
    int minNum = arr[0];
    int maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minNum > arr[i]) minNum = arr[i];
        if (maxNum < arr[i]) maxNum = arr[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {maxNum - minNum}");
}
RandomArray(arr);
GetDiffMaxMinNum(arr);
