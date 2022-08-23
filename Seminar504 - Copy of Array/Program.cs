int[] FillMas(int len, int min, int max){
    int[] mas = new int[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=new Random().Next(min, max);
    return (mas);
}

void PrintMas(int[] mas){
    int i;
    Console.Write("[");
    for(i=0;i<mas.Length-1;i++)
        Console.Write($"{mas[i]}, ");
    Console.Write($"{mas[i]}]");
    Console.WriteLine();
}

int[] CopyArr(int[] mas){
    int[] temp = new int[mas.Length];
    for(int i=0;i<mas.Length;i++)
        temp[i]=mas[i];
    
    return temp;
}

Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] mas = FillMas(len,1, 99);
Console.WriteLine($"Первоначальный массив:");
PrintMas(mas);
int[] copy = CopyArr(mas);
Console.WriteLine($"Копия массива:");
PrintMas(copy);