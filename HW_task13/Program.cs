
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
  Console.WriteLine("Третья цифра -> " + NumberText[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}