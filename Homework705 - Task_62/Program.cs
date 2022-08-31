int[,] FillArray(int rows, int cols){
    int[,] arr = new int[rows,cols];
    int count = 1;
    int i=0, j=0;
    for(i=0;i<rows;i++)
        for(j=0;j<cols;j++)
            arr[i,j]=0;
    i=-1;j=-1;
    while(count<rows*cols){
        i++;j++;
        for(j=j;j<cols;j++)
            if(arr[i,j]==0)arr[i,j]=count++;
            else break;
        j--;
        for(i++;i<rows;i++)
            if(arr[i,j]==0)arr[i,j]=count++;
            else break;
        i--;
        for(j--;j>=0;j--)
            if(arr[i,j]==0)arr[i,j]=count++;
            else break;
        j++;
        for(i--;i>=0;i--)
            if(arr[i,j]==0)arr[i,j]=count++;
            else break;
        }   
    return arr;
}

void PrintArr(int[,] arr){
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++)
            Console.Write($"{arr[i,j]:d2}  ");
    Console.Write("\n");
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());
PrintArr(FillArray(rows,cols));