int[] FillMas(int len){
    int[] mas = new int[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=new Random().Next(0, 100);
    return (mas);
}

void PrintMas(int[] mas){
    int i;
    Console.Write("[");
    for(i=0;i<mas.Length-1;i++)
        Console.Write($"{mas[i]}, ");
    Console.Write($"{mas[i]}]");
}

Console.Clear();
int[] mas = FillMas(8);
PrintMas(mas);