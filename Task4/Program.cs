Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
    Console.WriteLine(a);
    if (a > c)
    Console.WriteLine(a);
    if (b > c)
    Console.WriteLine(b);
    if (c > a)
Console.WriteLine(c);
    