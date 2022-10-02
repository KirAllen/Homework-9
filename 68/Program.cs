// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Enter first number");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter second number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetAkkerman(n,m));

int GetAkkerman(int n, int m)
{
  if (n == 0)
  {
    return m + 1;
  }
  else
  {
    if ((n != 0) && (m == 0))
    {
      return GetAkkerman(n - 1, 1);
    }
    else
    {
       return GetAkkerman(n - 1, GetAkkerman(n, m - 1));
    }
  }
}
