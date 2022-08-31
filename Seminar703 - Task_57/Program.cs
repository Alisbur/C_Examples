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

int[] 2DTo1D(int[,] mas){
    int count=0;
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

// int[,] Stats(int[] mas){
//     int val;
//     int count;
//     int i=0;
//     int[,] res=new int[mas.Length,2]
    
//     for(i=0;i<mas.Length;i++)
//         if[mas[i]=mas[i+1]
            

//     while(mas[i]==mas[i+1]){
//         i++;
//         count++;
//     }
    
//     for(int i=0;i<mas.Length;i++){
//         val!=mas[i];
//         count=0;
//         for(int j=0;j<mas.Length;j++){
//             if(mas[j]==val)count++
//         result

//         if()

//     }


// int[] Sort(int[] mas){
//     int[] res = mas;
//     int temp;
//     bool issorted=false;
//     while(!issorted){
//         issorted=true;
//         for(int i=0;i<mas.Length-1;i++)
//             if(res[i]<res[i+1]){
//                 issorted=false;
//                 temp=res[i];
//                 res[i]=res[i+1];
//                 res[i+1]=temp;
//             }
//     }
//     return res;
// }

Console.Clear();
int[] mas1 = {1,9,9,0,2,8,0,9};
int[,] mas2 = {{1,2,3},{4,6,1},{2,1,6}};


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int cols = int.Parse(Console.ReadLine());

// Console.WriteLine("Исходный массив:");
// int[,] arr = GetArr(rows,cols,0,10);
// PrintArr(arr);

// Console.WriteLine("Результат:");
// PrintArr(SwapFirstLastRows(arr));

Console.WriteLine(string.Join(", ", Sort(mas1)));