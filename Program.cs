/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int summ = 0;
int number1 = 0;
while (number > 0)
{
    number1 = number % 10;
    number = number / 10;
    summ = summ + number1;
}
Console.WriteLine($"итого {summ}");

