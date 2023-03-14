Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (0 == a % 2)
    Console.WriteLine($"Yes");
else
    Console.WriteLine($"No");