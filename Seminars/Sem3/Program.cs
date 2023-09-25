//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//int FindQuareter(int x, int y)
//{
  //  if(x>0 && y>0) return 1;
   // if(x<0 && y>0) return 2;
   // if(x<0 && y<0) return 3;
   // if(x>0 && y<0) return 4;
  //  return 0;
//}
//Console.WriteLine("Input X: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input Y: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(FindQuareter(int x, int y));


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//void QuadTable(int n)
//{
  //  int current = 1;
 //   Console.Write(n + " -> ");
  //  while(current < n)
 //   {
 //      System.Console.Write(current * current + ", ");
  //     current++;
  //  }
  //  Console.WriteLine(current * current);
//}
//Console.Write("Input N: ");
//int n = Convert.ToInt32(Console.ReadLine());
//QuadTable(n);


//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

double Distance (int double xa, double ya, double xb, double yb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2))
}
System.Console.WriteLine("Напиши значения координат: ");
System.Console.WriteLine();