int[] FillArray(int[] array)
{
    for(int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]}, ");
    }
    return(array);
}

int FindPosition(int[] array, int target)
{
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]==target)return(i);
    }
    return(-1);
}

int arrayLen = 0;
Console.Write("Введите длину массива: ");
arrayLen=int.Parse(Console.ReadLine());

int[] array = new int[arrayLen];
array=FillArray(array);

Console.WriteLine();
Console.Write("Введите число для поиска: ");
int target=int.Parse(Console.ReadLine());

int result = FindPosition(array,target);

if(result==-1)
    Console.WriteLine($"Нет вхождений");
else
    Console.WriteLine($"Номер элемента: {result}");
