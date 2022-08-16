int GetSum(int num){
    int sum = 0;
    while(num/10>0){
        sum+=num%10;
        num=num/10;
        }
    return (sum+num);
}

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе: {GetSum(num)}");


