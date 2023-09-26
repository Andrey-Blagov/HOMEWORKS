/*static bool IsPalindrome(int number)
{
    int number1 = new Random().Next(10000, 100000);
    //Console.Write("Insert 5-digit number: ");
    //int number1 = Convert.ToInt32(Console.ReadLine()); 
    int num1 = number1 / 10000 % 10;
    int num2 = number1 / 1000 % 10;
    int rev1 = number1 / 10 % 10;
    int rev2 = number1 % 10;
    int nul = number1 / 10000;
        
        if (nul < 1 || nul > 9)
        {
             Console.WriteLine("{number} ->  Not 5-digit number");
             return false;
        }
        else if  (num1 == rev2 && num2 == rev1)
        {
             return true;
             //Console.WriteLine($"{number} -> Yes, this is palindrom");
        }
        else
        {
             return false;
             //Console.WriteLine($"{number} -> No, this is not palindrom");
        }
}
bool result = IsPalindrome(number);
System.Console.WriteLine($"{result}");*/
