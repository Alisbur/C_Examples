Console.Write("Введите число: ");
int num=int.Parse(Console.ReadLine());

for(int i=1; i<(num+1);i++)
    if(i%2 == 0)
        Console.Write($"{i}, ");