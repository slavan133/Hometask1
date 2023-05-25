// Напишите программу, которая принимает на вход трёхзначное число и на выхожепоказывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 999 && number > 99)
{Console.WriteLine(number % 10);}
else
{Console.WriteLine("не трехзначное число");}