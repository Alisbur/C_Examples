{
int N=6;int N1=6;
int [,] pole=new int[N,N1];

for (int i = 0; i < pole.GetLength(0); i++)
    for (int j = 0; j < pole.GetLength(1); j++)
      pole[i,j]=0;

int x=0;int y=0;int count=1;
while (true)
{  if(pole[y,x]==0)
      {pole[y,x]=count++;
        if (x<pole.GetLength(1)-1)
            if(pole[y,x+1]==0){
                if (y>0 && pole[y-1,x]==0){
                    y--;
                    continue;
                }
                x++;
                continue;
            }

            if (y<pole.GetLength(0)-1)
            if(pole[y+1,x]==0){
                y++;
                continue;
            }

            if (x>0)
                if(pole[y,x-1]==0){
                    x--;
                    continue;
                }
           
            if (y>0)
                if(pole[y-1,x]==0){
                    y--;
                    continue;
                }
    } 
    break;
  }

Console.WriteLine("задача 62");

   for (int i = 0; i < pole.GetLength(0); i++)
    {   for (int j = 0; j < pole.GetLength(1); j++)
           Console.Write($"{pole[i,j]:d2} ");
        Console.WriteLine();
    }

Console.WriteLine("конец");
}
