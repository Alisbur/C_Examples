Console.Clear();

double time = 0, distance = 10000;
int speedFriend1 = 1, speedFriend2 = 2, speedDog = 5;
int count = 0, direction = 2;

while(distance > 10)
{
    Console.WriteLine("Прежняя дистанция " + distance);
 
    if(direction==2)
    {
        time = Math.Round(distance / (speedDog+speedFriend2));
        distance = distance - (speedFriend1+speedFriend2)*time;
        Console.WriteLine("Собака бежит к другу " + direction);
        direction = 1;
        count++;         
    }    
    else
    {
        time = Math.Round(distance / (speedDog+speedFriend1));
        distance = distance - (int)(speedFriend1+speedFriend2)*time;
        Console.WriteLine("Собака бежит к другу " + direction);
        direction = 2;
        count++;         
    }    
    
    Console.WriteLine("Собака бежала секунд " + time);
    Console.WriteLine("Собака пробежала раз " + count);
    Console.WriteLine("Новая дистанция между друзьями " + distance + "\n");

}
Console.WriteLine(count);

