string ToBinary(int x){    
    string res = string.Empty;
    string res1 = string.Empty;
    while(x>0){
        res+=(x%2).ToString();
        x/=2;
    }
    for(int i=res.Length-1;i>=0;i--)
        res1+=res[i];

    return res1;
}

Console.Clear();
Console.Write("Введите десятичное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} в двоичной системе {ToBinary(a)}");


