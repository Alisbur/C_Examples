int NumsSum(int m, int n){
    if(m==n) return n;
    return m+NumsSum(m+1,n);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {NumsSum(m,n)}");