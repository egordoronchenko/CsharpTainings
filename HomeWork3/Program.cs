
/*
int t, r;
int sum = 0;
bool IsPalindrom(int number)
    { for(t=number;number!=0;number=number/10)
        {
        r=number % 10;
        sum=sum*10+r;
        }
            if(t==sum)
            return true;
            else
            return false;
    } 

Console.WriteLine("Input a number");
link1:
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number <100000  )
    {bool result = IsPalindrom(number);
        if (result == true)
        Console.WriteLine("Палиндром");
        else Console.WriteLine("Число не палиндром");
     }
else
    {Console.WriteLine("число не пятизначное. Введите новое число");
    goto link1;
    }
    */


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// 
/*
int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int num, i;
void ShowCube(int num)
{
   for (i = 1; i < num+1; i++)
   Console.WriteLine($"{i} - {i*i*i}");
}
Console.WriteLine("Введеите число");
num=Convert.ToInt32(Console.ReadLine());

ShowCube(num);
*/




