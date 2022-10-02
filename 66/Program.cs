// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Enter first number");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter second number");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0; 

Console.WriteLine(FindSum(m, n));

int FindSum(int start, int end)
{
    for(int i = start; i <= end; i++)
    {
        sum = sum + i; 
    }
    return sum; 
}
