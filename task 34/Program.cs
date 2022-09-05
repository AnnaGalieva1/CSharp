// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int [] arr = new int [20];

void RandomArray(int[]array)
{
    for (int i = 0; i < arr.Length; i++)
{
    Random rnd = new Random();
    int value = rnd.Next(100,1000);
    arr[i] = value;
    Console.WriteLine($"{arr[i]}");
}
}
void GetEven(int[]array)
{
    int evenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве - {evenNum}");
}
RandomArray(arr);
GetEven(arr);