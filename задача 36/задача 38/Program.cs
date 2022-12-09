﻿//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(Console.ReadLine());

double[] number = new double[size];
FillArrayRandomNumbers(number);

Console.WriteLine("Массив: ");
PrintArray(number);


double min = double.MaxValue;
double max = double.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}

Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
