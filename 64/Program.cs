﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(PrintNumbers(num, 1));

string PrintNumbers(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    return(start + "," + PrintNumbers(start - 1, end)); 
}
