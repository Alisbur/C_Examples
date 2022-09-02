int Akkerman(int m, int n){
    if(m==0) return n+1;
    else if((n==0)&&(m>0)) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккрмана при m = {m} и n = {n} -> {Akkerman(m,n)}");