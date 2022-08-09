Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if((num>99)&&(num<1000))
    Console.WriteLine($"Вторая цифра числа: {num/10%10}");
else
    Console.WriteLine("Введено неправильное число");


