/* void ArrayDigital (string[] args)
{
    Console.Write("Введите количество чисел: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int count = 0;
    for(int i = 0; i < n; i++)
    {
      Console.Write("Введите число №" + (i+1) + ": ");
      int num = Convert.ToInt32(Console.ReadLine());
      
      if(num > 0)
        count++;
    }
    
    Console.WriteLine("Количество чисел больше 0: " + count);
}
ArrayDigital(args); */

System.Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
