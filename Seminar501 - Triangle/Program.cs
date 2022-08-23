Console.Clear();
Console.Write("Введите сторону A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите сторону B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите сторону C: ");
int c = int.Parse(Console.ReadLine());
if(((a+b)>c)&&((a+c)>b)&&((b+c)>a)) Console.WriteLine("треугольник может существовать");
else Console.WriteLine("треугольник НЕ может существовать");