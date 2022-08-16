int MyPow(int num, int pow){    
    int res=1;
    for(int i=0;i<pow;i++)
        res*=num;
    return(res);
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int pow = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат возведения в степень: {MyPow(num,pow)}");