
       
// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
 Console.Clear();
 int[] startArray = GetArray(10, 100, 999);

 Console.Write($"[{string.Join(", ",startArray)}]");

 Console.WriteLine($"Количество чётных чисел в отрезке [100;999] = {GetCountElements(startArray, 100, 999)}");

 int[] GetArray(int size, int minValue, int maxValue)           
 {
     int[] res = new int[size]; 
     
    for (int i = 0; i < size; i++)
    {
         res[i] = new Random().Next( minValue, maxValue + 1 );
    }
    return res;
 }

 int GetCountElements(int[] array, int leftRahge, int rigthRange)
 {
     int count = 0;
     foreach ( var item in array)
     {
        if (item %2==0) count++;
     }
     return count;
 }  

            