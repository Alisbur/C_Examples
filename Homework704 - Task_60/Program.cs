int[,,] GetArr3D(int rows, int cols, int dep){
    int[,,] arr = new int[rows,cols,dep];
    int count=11;
    
    for(int i=0;i<rows;i++)
        for(int j=0;j<cols;j++)
            for(int d=0;d<dep;d++)
                arr[i,j,d] = count++;
    return arr;
}

void PrintArr3D(int[,,] arr){

    for(int d=0;d<arr.GetLength(2);d++)
        for(int i=0;i<arr.GetLength(0);i++){
            for(int j=0;j<arr.GetLength(1);j++)
                Console.Write($"{arr[i,j,d]} ({i}, {j}, {d})  ");
        Console.Write("\n");
        }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());
Console.Write("Введите глубину: ");
int dep = int.Parse(Console.ReadLine());

PrintArr3D(GetArr3D(rows,cols,dep));