int  LastDigit(int x){
    if (x<10) return x;
    return x%10+LastDigit(x/10);
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Результат: {LastDigit(num)}");
