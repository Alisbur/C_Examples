int GetFact(int num){
    int mult = 1;
      
    for(int i=1; i<=num; i++){
        mult*=i;
        }
    return (mult);
}

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Факториал числа {num} равен {GetFact(num)}");


