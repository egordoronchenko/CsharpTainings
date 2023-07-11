/*
void ShowDiapazone (int quad)
{
    if (quad == 1) Console.WriteLine("x>0 and y>0");
    else if(quad == 2) Console.WriteLine("x<0 and y>0");
    else if(quad == 3) Console.WriteLine("x<0 and y<0");
    else if(quad == 4) Console.WriteLine("x>0 and y<0");
    else Console.WriteLine("Wrong input");
}

Console.WriteLine("Input a number of quadrant (from 1 to 4)");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapazone(quadrant);
*/

//Math.Sqrt
/*
int NumQuad (int x, int y)
{
    int quad = 0;
    if (x>0 & y > 0)   quad =1;
    else if(x<0 & y > 0) quad =2;
    else if(x<0 & y < 0) quad =3;
    else if(x>0 & y < 0) quad =4;

    return quad;

}
Console.WriteLine("Введите координату х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());

int result = NumQuad(x, y);

Console.WriteLine(result);
*/

/*
double Rasst (int x1, int y1, int x2, int y2)
{
int katet1 = x2 - x1;
int katet2 = y2 - y1;
double rasst1= Math.Sqrt(katet1*katet1+katet2*katet2);
return rasst1;
}
Console.WriteLine("Введите координаты первой точки х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
double result = Rasst(x1, y2, x2, y2);
Console.WriteLine($"Расстояние равно {result}");

*/

 void Kvadr (int Num)
    {
    int count = 1;
        while (count <= Num)
        {
            int kv = count * count;
            Console.WriteLine (count + " - " + kv);
            count++;
        }
    }

 Console.WriteLine ("Введите число: ");
 int N = Convert.ToInt32 (Console.ReadLine());
 Kvadr (N);