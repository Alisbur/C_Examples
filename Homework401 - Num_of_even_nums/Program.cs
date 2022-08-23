int[] FillMas(int len){
    int[] mas = new int[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=new Random().Next(100, 999);
    return (mas);
}

int CountEven(int[] mas){
    int count = 0;    
    for(int i=0;i<mas.Length;i++)
        if(mas[i]%2==0)
            count++;
    return count;
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
Console.WriteLine($"В массиве {CountEven(mas)} чётных чисел");