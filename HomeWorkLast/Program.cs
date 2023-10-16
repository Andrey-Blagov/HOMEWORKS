/* 
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
PrintArray(array); */


/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}




for(int i = 0; i < matrix.GetLength(0); i++)
      {
           for(int j = 0; j < matrix.GetLength(1) + 1; j++)
           {
                if(matrix[i, j] > matrix[i, j - 1])
                {
                     int temp = matrix[i, j];
                     matrix[i, j] = matrix[i, j - 1];
                     matrix[i, j - 1] = temp;
                 }
           }
      }