Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int c = int.Parse(Console.ReadLine()!);
int Max = a;
if (Max < b)
      Console.WriteLine($"Max = {b}");
else if (Max < c)
    Console.WriteLine($"Max = {c}");
else
    Console.WriteLine($"Max = {a}");