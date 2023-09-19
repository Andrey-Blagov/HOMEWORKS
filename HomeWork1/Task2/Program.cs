//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (b > a) max = b;
if (b > a) min = a;
System.Console.WriteLine($"Max= {max}, Min= {min}");