// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int a = new Random().Next(100, 1000);
System.Console.Write("Заданое число: " + a);

int m = a % 100;
int n = m / 10;

System.Console.WriteLine();
System.Console.Write("Вторая цифра в числе: " + n);