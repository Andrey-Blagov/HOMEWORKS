






int[] array = { 1, 4, 8, 100, 4, 9};
int max = array [0];
//int temp = array[0];
for (int i = 0; i < array.Length; i++)
{  
   if (array[i] > max) max = array[i];
   //array[0] = temp;
   //max = array[0];
   //temp = 
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}
Console.WriteLine($"{max}");
PrintArray(array);
