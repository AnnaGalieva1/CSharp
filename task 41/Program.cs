﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество числел М: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[M];

void InputNumbers(int M)
{
    int i = 0;
    while (i < M)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}
int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for(int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count +=1;
    }
    return count;
}
InputNumbers(M);
Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)}");
