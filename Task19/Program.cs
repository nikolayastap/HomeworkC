Console.Clear();
Console.Write("Введите пятизначное число: ");
string anyNumberText = Console.ReadLine()!;
if (anyNumberText[0] == anyNumberText[4] && anyNumberText[1] == anyNumberText[3])
{
  Console.WriteLine("Да");
}
else {
  Console.WriteLine("Нет");
}