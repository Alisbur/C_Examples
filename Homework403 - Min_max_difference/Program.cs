double[] FillMasD(int len, int min, int max){
    Random a = new Random();
    double[] mas = new double[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=a.NextDouble()*(max-min);;
    return (mas);
}

double FindMaxD(double[] mas){
    double max = mas[0];
    for(int i=0;i<mas.Length;i++)
        if(mas[i]>max) max=mas[i];
    return max;
}

double FindMinD(double[] mas){
    double min = mas[0];
    for(int i=0;i<mas.Length;i++)
        if(mas[i]<min) min=mas[i];
    return min;
}

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

void PrintMasD(double[] mas){
    int i;
    Console.Write("[");
    for(i=0;i<mas.Length-1;i++)
        Console.Write($"{mas[i]:f2}, ");
    Console.Write($"{mas[i]:f2}]");
    Console.WriteLine();
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
double[] mas = FillMasD(len,1, 99);
PrintMasD(mas);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {FindMaxD(mas)-FindMinD(mas):f2}");
