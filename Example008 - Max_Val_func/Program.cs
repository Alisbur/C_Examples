int MaxVal (int num1, int num2, int num3)
{
    int max=num1;
    if(num2>max)max=num2;
    if(num3>max)max=num3;
    return(max);
}

int a1 = 11, b1 = 15, c1 = 22;
int a2 = 1, b2 = 125, c2 = 221;
int a3 = 6, b3 = 115, c3 = 212;

int result = MaxVal(MaxVal(a1,b1,c1),MaxVal(a2,b2,c2),MaxVal(a3,b3,c3));

Console.WriteLine($"Максимальное число: {result}");
