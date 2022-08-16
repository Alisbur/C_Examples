int GetNum(int num){
    int sum = 0;
    
    while(num/10>0){
        sum++;;
        num=num/10;
        }
    return (sum+1);
}

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе: {GetNum(num)}");


