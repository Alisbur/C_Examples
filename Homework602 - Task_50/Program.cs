int[,] GetArr(int rows, int cols, int min, int max){
    int[,] arr = new int[rows,cols];
    
    for(int i=0;i<rows;i++){
        for(int j=0;j<cols;j++)
            arr[i,j] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArr(int[,] arr){
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++)
            Console.Write($"{arr[i,j]}  ");
    Console.Write("\n");
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив:");
int[,] arr = GetArr(rows,cols,0,10);
PrintArr(arr);

Console.Write("Введите строку элемента (отсчёт начинается с 0): ");
int r = int.Parse(Console.ReadLine());
Console.Write("Введите столбец элемента (отсчёт начинается с 0): ");
int c = int.Parse(Console.ReadLine());
if((r>=0)&&(r<arr.GetLength(0))&&(c>=0)&&(c<arr.GetLength(1)))
    Console.WriteLine($"Элемент в строке {r} и столбце {c} -> {arr[r,c]}");
else
    Console.WriteLine($"Элемент с такими индексами отсутствует");