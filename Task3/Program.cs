//Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3-> среда
// 5-> пятница

Console.WriteLine("Введите число");
int numberofday = Convert.ToInt32(Console.ReadLine());
if (numberofday == 1) Console.WriteLine("Monday");
else if (numberofday == 2) Console.WriteLine("Tuesday");
else if (numberofday == 3) Console.WriteLine("Wednesday");
else if (numberofday == 4) Console.WriteLine("Thirsday");
else if (numberofday == 5) Console.WriteLine("Friday");
else if (numberofday == 6) Console.WriteLine("Saturday");
else if (numberofday == 7) Console.WriteLine("Sunday");
else Console.WriteLine("Нет такого номера дня недели");