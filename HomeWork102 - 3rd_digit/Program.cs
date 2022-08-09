Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int counter = 0;

if(num>99){
    while(num/(int)Math.Pow(10,counter)>0) counter++;
    int thirdDigit = (num/(int)Math.Pow(10,counter-3))%10;
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}   
else
    Console.WriteLine("Введено неправильное число");