int[,] GetArr(int rows, int cols, int min, int max){
    int[,] arr = new int[rows,cols];
    
    for(int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            arr[i,j] = new Random().Next(min, max);
        }
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

int FindMinSumRow(int [,] arr){
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int[] sums = new int[rows];
    
    for(int i=0;i<rows;i++)
        for(int j=0;j<cols-1;j++)
            sums[i]+=arr[i,j];
    
    int minInd=0;
    int min = sums[minInd];
    
    for(int i=0;i<sums.Length;i++)
        if(sums[i]<min){
            min=sums[i];
            minInd=i;
        }
    
    return minInd;    
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив:");
int[,] arr = GetArr(rows,cols,0,10);
PrintArr(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinSumRow(arr)}");