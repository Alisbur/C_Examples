int[,] GetArr(int rows, int cols, int min, int max){
    int[,] arr = new int[rows,cols];
    
    for(int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            arr[i,j] = new Random().Next(min, max);
        }
    }
    return arr;
}

int [,] ReplaceEvenElements(int [,] arr){
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    
    int[,] temp = new int[rows,cols];
    
    for(int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            if((i%2==0)&&(j%2==0)) temp[i,j] = arr[i,j]*arr[i,j];
            else temp[i,j] = arr[i,j];
        }
    }
    return temp;    
}

int [,] SwapFirstLastRows(int [,] arr){
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int[,] temp = new int[rows,cols];

    for(int i=0;i<cols;i++){
            temp[0,i]=arr[rows-1,i];
            temp[rows-1,i]=arr[0,i];
    }
    return temp;    
}

void PrintArr(int[,] arr){
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++)
            Console.Write($"{arr[i,j]}  ");
    Console.Write("\n");
    }
}

int[,] RemoveMinElementRowCol(int[,] arr){
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int min,minR=0,minC=0;
    min=arr[0,0];
    for(int i=0;i<rows;i++)
        for(int j=0;j<cols;j++){
            if(min>arr[i,j]){
                min=arr[i,j];
                minR=i;
                minC=j;
            }
        }
    
    int ii=0, jj=0;
    int[,] temp = new int[rows-1,cols-1];
    for(int i=0;i<rows;i++){
        jj=0;
        for(int j=0;j<cols;j++){
            temp[ii,jj]=arr[i,j];
            if(j!=minC)jj++;
        }
        if(i!=minR)ii++;
        }
    return temp;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

Console.WriteLine("Исходный массив:");
int[,] arr = GetArr(rows,cols,0,10);
PrintArr(arr);
Console.WriteLine("Результат:");
PrintArr(RemoveMinElementRowCol(arr));