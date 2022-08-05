Console.Write("Введите первое число: ");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2=int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3=int.Parse(Console.ReadLine());

int maxVal = num1;
string max="Первое";

if(num2>maxVal)
{
    maxVal=num2;
    max="Второе";
}
if (num3>maxVal)
{
    maxVal=num3;
    max="Третье";
}

Console.WriteLine($"{max} число {maxVal} максимальное");