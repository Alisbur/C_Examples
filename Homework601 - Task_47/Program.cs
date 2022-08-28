double[,] GetArrD(int rows, int cols, int min, int max){
    double[,] arr = new double[rows,cols];
    
    for(int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            arr[i,j] = new Random().NextDouble()*(max-min);
        }
    }
    return arr;
}

void PrintArr(double[,] arr){
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++)
            Console.Write($"{arr[i,j]:f2}  ");
    Console.Write("\n");
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

PrintArr(GetArrD(rows,cols,0,10));