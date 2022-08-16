int[] FillMas(int len){
    int[] mas = new int[len];
    for(int i=0; i<mas.Length; i++)
        mas[i]=new Random().Next(2);
    return (mas);
}

void PrintMas(int[] mas){
    int i;
    Console.WriteLine();
    Console.WriteLine(string.Join(", ", mas));    
    // for(i=0;i<mas.Length-1;i++)
    //     Console.Write($"{mas[i]}, ");
    // Console.Write($"{mas[i]}");
}

Console.Clear();
Console.WriteLine("Введите длину массива ");
int num = int.Parse(Console.ReadLine());
PrintMas(FillMas(num));