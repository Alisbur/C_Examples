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

int[] ConvertArray2Dto1D(int[,] arr){
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int count=0;
    int[] result = new int[rows*cols];

    for(int i=0;i<rows;i++)
        for(int j=0;j<cols;j++){
            result[count]=arr[i,j];
            count++;
            }
    return result;
}

int[] Sort(int[] mas){
    int[] res = mas;
    int temp;
    bool issorted=false;
    while(!issorted){
        issorted=true;
        for(int i=0;i<mas.Length-1;i++)
            if(res[i]<res[i+1]){
                issorted=false;
                temp=res[i];
                res[i]=res[i+1];
                res[i+1]=temp;
            }
    }
    return res;
}

int GetStat(int[] arr, int x ){
    int count=0;
    for(int i=0;i<arr.Length;i++)
        if(arr[i]==x) count++;
    return count;
}

Console.Clear();

// int[] mas2 = {1,9,9,0,2,8,0,9};
// int[,] mas2 = {{1,2,3},{4,6,1},{2,1,6}};

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

Console.WriteLine("Исходный массив:");
int[,] mas2 = GetArr(rows,cols,0,10);
PrintArr(mas2);

int[] temp = Sort(ConvertArray2Dto1D(mas2));

Console.WriteLine(string.Join(", ", ConvertArray2Dto1D(mas2)));
Console.WriteLine(string.Join(", ", temp));

for(int i=0;i<temp.Length;i++)
    if((i==0)||((i>0)&&(temp[i]!=temp[i-1])))
        Console.WriteLine($"Элемент {temp[i]} встречается {GetStat(temp,temp[i])} раз;");