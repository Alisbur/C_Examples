Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num>99)
//    Console.WriteLine($"Третья цифра числа: {num/100%10}");
{
    String str = num.ToString();
    Console.WriteLine(int.Parse(str[2].ToString()));
}
else
    Console.WriteLine("Введено неправильное число");