Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!), i = (0);
while(i + 2 < N)
{
  i = i + 2;
  Console.Write($"{i} ");
}