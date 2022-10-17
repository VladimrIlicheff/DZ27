/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

//метод который получает число с консоли
//ЧИсло цифр

/*void getNumber()
{
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);
string numAsString = number.ToString();

int length = numAsString.Length;

Console.WriteLine($"{length}");
}
getNumber();*/



Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);
int count = 0;
int summ = 0;

while (number)

{
    count = count + 1;
    number = number % 10;
    summ = summ + number;
}
Console.WriteLine($"итого {summ}");

