void Nums(int m, int n){
    Console.Write($"{m}, ");
    if (m<n)
        Nums(m+1,n);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Nums(m,n);