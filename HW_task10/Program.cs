Console.Clear();
int Number = new Random().Next(100,1000);
Console.WriteLine(Number);
string secondDigit = Convert.ToString(Number);
Console.WriteLine("вторая цифра числа -> "+secondDigit[1]);
