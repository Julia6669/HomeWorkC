﻿Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i ++)
{
if (i % 2 == 0)
Console.Write($"{i} ");
}