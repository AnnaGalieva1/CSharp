// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int getRate(int number1, int number2)
{
    int totalNumber = number1;
    for(int i = 1; i < number2; i++)
    {
        totalNumber *= number1;
    }
    return totalNumber;
}
Console.WriteLine($"Результат = {getRate(number1, number2)}");
