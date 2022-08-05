Console.Write("Введите первое число: ");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2=int.Parse(Console.ReadLine());

if(num1>num2)
    Console.WriteLine($"Первое число {num1} большее");
else if(num1==num2)
    Console.WriteLine($"Числа {num1} и {num2} равны");
else
    Console.WriteLine($"Второе число {num2} большее");