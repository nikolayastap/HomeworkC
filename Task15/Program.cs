Console.Clear();
Console.Write("Введите день недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
  Console.Write("Вы ошиблись! \nВведите день недели: ");
  n = int.Parse(Console.ReadLine()!);
}
if (n > 5)
  Console.WriteLine("Да");
else
  Console.WriteLine("Нет");
