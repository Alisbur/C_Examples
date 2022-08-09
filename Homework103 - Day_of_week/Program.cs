Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if((num>=1)&&(num<=7))
    Console.WriteLine(((num==6)||(num==7))?"Выходной":"Рабочий");
else
    Console.WriteLine("Дня с таким номером нет в неделе");