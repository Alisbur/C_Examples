int MaxVal (int num1, int num2, int num3)
{
    int max=num1;
    if(num2>max)max=num2;
    if(num3>max)max=num3;
    return(max);
}

int[] array = {11,15,22,1,125,221,6,115,212};

int result = MaxVal(MaxVal(array[0],array[1],array[2]),
                    MaxVal(array[3],array[4],array[5]),
                    MaxVal(array[6],array[7],array[8]));

Console.WriteLine($"Максимальное число: {result}");
