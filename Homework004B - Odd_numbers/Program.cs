Console.Write("Введите число: ");
int num=int.Parse(Console.ReadLine());
int i = 1;

while(i<=num)
{
    if(i%2 == 0)
        Console.Write($"{i}, ");
    i++;
}