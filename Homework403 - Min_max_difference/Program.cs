int[] FillMas(int len, int min, int max){
    int[] mas = new int[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=new Random().Next(min, max);
    return (mas);
}

int FindMax(int[] mas){
    int max = mas[0];
    for(int i=0;i<mas.Length;i++)
        if(mas[i]>max) max=mas[i];
    return max;
}

int FindMin(int[] mas){
    int min = mas[0];
    for(int i=0;i<mas.Length;i++)
        if(mas[i]<min) min=mas[i];
    return min;
}

void PrintMas(int[] mas){
    int i;
    Console.Write("[");
    for(i=0;i<mas.Length-1;i++)
        Console.Write($"{mas[i]}, ");
    Console.Write($"{mas[i]}]");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] mas = FillMas(len,1, 99);
PrintMas(mas);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {FindMax(mas)-FindMin(mas)}");
