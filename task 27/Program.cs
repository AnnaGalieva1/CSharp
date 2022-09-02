// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int getSumOfNumbers(int number)
{
    int totalNumber = 0;
    while(number > 0)
    {
        totalNumber = totalNumber + number % 10;
        number = number / 10;
    }
    return totalNumber;
}
Console.WriteLine($"Сумма чисел в числе: {getSumOfNumbers(number)}");