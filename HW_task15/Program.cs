Console.Write("Введите день недели: ");
int dayNumber = int.Parse(Console.ReadLine()!);
if (dayNumber == 6 || dayNumber == 7) 
{
  Console.WriteLine("Выходной");
}
  else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("В неделе всего семь дней блин!!!!");
}
  else 
  {
    Console.WriteLine("Рабочий");
  }

