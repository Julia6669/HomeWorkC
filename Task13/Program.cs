//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите любое число: ");
int n = new Random().Next(10, 10000000);
Console.WriteLine($"Случайно сгенирированное число {n}");
while(n > 1000)
n = n / 10;
Console.WriteLine(n % 10);