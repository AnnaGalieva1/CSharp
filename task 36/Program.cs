// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).

int[] arr = new int[5];
void RandomArray(int[]array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(-100,100);
        arr[i] = value;
        Console.WriteLine($"{arr[i]}");
    }
}
RandomArray(arr);

void GetOddSum(int[] array)
{
    int oddSum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        oddSum += arr[i];
    }
    Console.WriteLine($"Сумма элементов с нечетным индексом = {oddSum}");
}
GetOddSum(arr);
