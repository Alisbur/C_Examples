int  PowAB(int a, int b){
    if (b==1) return a;
    return a*PowAB(a,b-1);
}

Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());


Console.WriteLine($"Результат: {PowAB(a,b)}");
