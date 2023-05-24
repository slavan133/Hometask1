// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b=5, -> да
// а = 2, b=10, -> нет

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int kvadrat = (number2 * number2);
if (kvadrat == number1)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}