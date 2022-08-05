Console.Write("Введите число: ");
int num1=int.Parse(Console.ReadLine());

if(num1%2 == 0)
    Console.WriteLine($"Вы ввели чётное число");
else
    Console.WriteLine($"Вы ввели нечётное число");