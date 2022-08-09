Console.Write("Введите первое число: ");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите ворое число: ");
int num2=int.Parse(Console.ReadLine());

if(num1%num2 == 0)
    Console.WriteLine($"Первое число кратно второму");
else
    Console.WriteLine($"Первое число не кратно второму, остаток {num1%num2}");