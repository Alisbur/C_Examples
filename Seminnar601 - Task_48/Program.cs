int[,] GetArr(int rows, int cols, int min, int max){
    int[,] arr = new int[rows,cols];
    
    for(int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            arr[i,j] = i+j;
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

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

PrintArr(GetArr(rows,cols,0,10));
