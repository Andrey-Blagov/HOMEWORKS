/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

System.Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
int size = 1;
int result = a;
while (size < b)
{
    result = result * a;
    size++;
}
System.Console.WriteLine($"A в степени B: {result}");



/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void SumDigital(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    Console.WriteLine("Сумма цифр в числе: " + sum);
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
SumDigital(num);



/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
   {
    array[i] = new Random().Next(minValue, maxValue + 1);
   }
   return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(size, min, max)); 

