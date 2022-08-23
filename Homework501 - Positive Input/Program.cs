int InputNumber(){
    Console.Write("Введите число: ");
    return (int.Parse(Console.ReadLine()));
}

int negativeCount=0;
Console.Clear();
Console.Write("Введите количество чисел для ввода: ");
int m = int.Parse(Console.ReadLine());

for(int i=0;i<m;i++){
    if(InputNumber()<0) negativeCount++;
}

Console.WriteLine($"Введено отрицательных чисел {negativeCount}");