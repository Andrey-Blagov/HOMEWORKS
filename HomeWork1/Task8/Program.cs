//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 0;
while (x < n - 1)
{
    Console.Write($"{x = x + 2}, ");
}
