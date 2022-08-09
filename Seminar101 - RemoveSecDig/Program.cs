int num = new Random().Next(100, 999);
Console.WriteLine($"Число: {num}");
int a = num/100*10 + num%10;
Console.WriteLine($"Результат: {a}");


