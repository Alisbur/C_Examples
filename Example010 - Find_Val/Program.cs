int[] array = {11,15,22,1,125,221,6,115,212};
int i=0;
int result=-1;

Console.Write("Введите число для поиска: ");
int target=int.Parse(Console.ReadLine());

while(i<array.Length)
{
    if(array[i]==target)
    {
        result=i;
        break;
    }
    i++;
}

if(result==-1)
    Console.WriteLine($"Нет вхождений");
else
    Console.WriteLine($"Номер элемента: {result}");
