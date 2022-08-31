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

int[,] MatrinxMultiplication(int[,] A, int[,] B){
    
    int rowsA=A.GetLength(0);
    int rowsB=B.GetLength(0);
    int colsA=A.GetLength(1);
    int colsB=B.GetLength(1);
    int[,] C = new int[rowsA,colsB];
    if(colsA!=rowsB){
        Console.Write("Размер матриц не позволяет произвести их умножение");
        return A;}
    for(int i=0;i<rowsA;i++)
        for(int j=0;j<colsB;j++)
            for(int ii=0;ii<colsA;ii++){
                C[i,j]+=A[i,ii]*B[ii,j];
            }
    return C;
    }

int[,] A = {{2,4},{3,2}};
int[,] B = {{3,4},{3,3}};
Console.Clear();
Console.WriteLine("Матрица A");
PrintArr(A);
Console.WriteLine("Матрица B");
PrintArr(B);
Console.WriteLine("Результат:");
PrintArr(MatrinxMultiplication(A,B));