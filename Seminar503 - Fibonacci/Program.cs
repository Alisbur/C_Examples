int[] CountFib(int x){    
    int[] arr = new int[x];
    arr[0] = 0;
    arr[1] = 1;
    for(int i=2;i<x;i++){
        arr[i]=arr[i-1]+arr[i-2];
    }
    return arr;
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
Console.Write("Введите число для вычисления последовательности Фибоначчи: ");
int a = int.Parse(Console.ReadLine());
PrintMas(CountFib(a));
