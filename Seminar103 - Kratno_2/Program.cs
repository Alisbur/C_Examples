Console.Write("Введите первое число: ");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2=int.Parse(Console.ReadLine());

Console.WriteLine((num1*num1==num2)||(num2*num2==num1)?"является":"не является");
