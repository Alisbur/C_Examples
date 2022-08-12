Console.Clear();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if(x>0)Console.WriteLine((y>0)?"Четверть №1":"Четверть №4");
else Console.WriteLine((y>0)?"Четверть №2":"Четверть №3");