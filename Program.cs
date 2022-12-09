//*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
            // Напишите программу, которая покажет количество чётных чисел в массиве.
            arrayLenght = 6;
            arrayMaxValue = 1000;
            arrayMinValue = 100;
            count = 0;

            arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);

            // Console.WriteLine($"[{String.Join("; ", arrayInt)}]");

            for (int i = 0; i < arrayLenght; i++)
            {
                if (arrayInt[i] % 2 == 0) count++;
            }
            Console.WriteLine($"Количество чётных чисел = {count}");
            WaitingToAnyKey();

            break;
