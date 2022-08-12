double CountLen(int x1, int y1, int x2, int y2, int z1, int z2){
    double len = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
    return(len);
}

Console.Clear();
Console.WriteLine("Введите координаты первой точки");
Console.Write("X = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z = ");
int z1 = int.Parse(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки");
Console.Write("X = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z = ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние = {CountLen(x1,y1,x2,y2,z1,z2):f2}");