Console.Clear();
Console.Write("Введите трухзначенное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
  {
    Console.Write("Вы ошиблись! \n Введите трехзначенное число: ");
    n = int.Parse(Console.ReadLine()!);
  }
Console.WriteLine(n / 10 % 10);