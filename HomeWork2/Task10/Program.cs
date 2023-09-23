void digitals(int num)
{
    int hund = num / 100;
    int dec = (num / 10) % 10;
    int ed = num % 10;
    if(hund == 0 && dec == 0)
    {
      Console.WriteLine($"Число {num} - Число ОДНОЗНАЧНОЕ !");
    }  
    else
    {
     if(hund > 0)
     {
         Console.WriteLine($"{num} -> Второй знак {dec}, Третий знак {hund}");
     }
     else
     {
         Console.WriteLine($"{num} -> Второй знак {dec}, Третий знак ОТСУТСТВУЕТ");
     } 
    }
}
int num = new Random().Next(0,10);
digitals(num);
