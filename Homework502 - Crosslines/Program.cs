double CalculateX(double b1, double k1, double b2, double k2){
    return ((b2-b1)/(k1-k2));
}

double CalculateY(double b1, double k1, double x){
    return (k1*x+b1);
}

Console.Clear();
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Координаты точки пересечения прямых ({CalculateX(b1,k1,b2,k2):f2}, {CalculateY(b1,k1,CalculateX(b1,k1,b2,k2)):f2})");