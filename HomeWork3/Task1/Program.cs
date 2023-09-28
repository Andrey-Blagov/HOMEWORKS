void palindrom(int number)
{
    //int number = new Random().Next(10000, 100000);
    //Console.Write("Insert 5-digit number: ");
    //int number = Convert.ToInt32(Console.ReadLine()); 
    int num1 = number / 10000; //9
    int num2 = number / 1000 % 10; //8
    int rev1 = number / 10 % 10; //8
    int rev2 = number % 10; //9
    int nul = number / 10000;
        
        if (nul < 1 || nul > 9)
        {
             Console.WriteLine($"{number} ->  Not 5-digit number");
        }
        else if  (num1 == rev2 && num2 == rev1)
        {
             Console.WriteLine($"{number} -> Yes, this is palindrom");
        }
        else
        {
             Console.WriteLine($"{number} -> No, this is not palindrom");
        }
}

Console.Write("Insert 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

palindrom(number);
