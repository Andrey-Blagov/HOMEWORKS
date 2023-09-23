//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfTheWeek(int num)
{
    if(num > 5)
    {
        System.Console.WriteLine($"{num} - Сегодня Выходной!!!");
    }
    else
    {
        System.Console.WriteLine($"{num} - На Работу(((");
    }
}
int num = new Random().Next(1,8);
DayOfTheWeek(num);
