Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int i;

if(num>=0){
    for(i=1;i<num;i++)
        Console.Write($"{Math.Pow(i,3)}, ");
    Console.Write($"{Math.Pow(i,3)}");
}
else{
    for(i=1;i>num;i--)
        Console.Write($"{Math.Pow(i,3)}, ");
    Console.Write($"{Math.Pow(i,3)}");
}