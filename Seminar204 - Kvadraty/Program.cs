Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int i;

for(i=1;i<num;i++)
    Console.Write($"{Math.Pow(i,2)}, ");
Console.Write($"{Math.Pow(i,2)}");