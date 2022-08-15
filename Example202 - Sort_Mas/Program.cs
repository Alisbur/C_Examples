int[] SortMas(int[] mas, int type){
    int temp;
    int maxInd;
  
    for(int i=0;i<mas.Length-1;i++){
        maxInd=i;
        for(int j=i+1;j<mas.Length;j++){
            if((type!=0)&&(mas[j]>mas[maxInd]))
                maxInd=j;
            if((type==0)&&(mas[j]<mas[maxInd]))
                maxInd=j;
            }   
        temp=mas[i];
        mas[i]=mas[maxInd];
        mas[maxInd]=temp;
    }
    return mas;
}

int[] FillMas(int len){
    int[] mas = new int[len];
    
    for(int i=0;i<mas.Length;i++)
        mas[i]=new Random().Next(1,20);
    
    return(mas);
}

void PrintMas(int[] mas){
    for(int i=0;i<mas.Length;i++)
        Console.Write($"{mas[i]}, ");
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите длину массива");
int len = int.Parse(Console.ReadLine());

int[] mas = new int[len];

Console.WriteLine("Массив: ");
mas=FillMas(len);
PrintMas(mas);

Console.WriteLine("Введите тип сортировки (0 - по возр., 1 - по убыв.)");
int type = int.Parse(Console.ReadLine());

Console.WriteLine("Отсортированный массив: ");
mas=SortMas(mas,type);
PrintMas(mas);