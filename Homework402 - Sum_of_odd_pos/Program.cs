int[] FillMas(int len){
    int[] mas = new int[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=new Random().Next(-99, 99);
    return (mas);
}

int SumOfOddPosElements(int[] mas){
    int sum = 0;    
    if(mas.Length<2)
        return 0;
    for(int i=1;i<mas.Length;i+=2)
        sum+=mas[i];
    return sum;
}

void PrintMas(int[] mas){
    int i;
    Console.Write("[");
    for(i=0;i<mas.Length-1;i++)
        Console.Write($"{mas[i]}, ");
    Console.Write($"{mas[i]}]");
}

Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] mas = FillMas(len);
PrintMas(mas);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива на нечётных позициях: {SumOfOddPosElements(mas)}");