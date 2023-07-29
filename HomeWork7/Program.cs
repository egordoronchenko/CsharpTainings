/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными
 числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
int Readint(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}
double RandomDouble()
{
   double randomNumber  = new Random().Next(-10,11) + Math.Round(new Random().NextDouble(),2) ; 
    return randomNumber;
}
double [,] CreateArray (int m, int n)
{
    double [,] array = new double [m,n] ;
    for (int i = 0; i < m ; i++)
    {
        for (int j = 0;j < n ; j++)
        {
            array[i,j] = RandomDouble();
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+", ");
        }
        Console.WriteLine();
    }
}

int m = Readint("Введите количество строк");
int n = Readint("Введите количество столбцов");

double[,] myArray = CreateArray(m, n);
ShowArray(myArray); 
*/


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/
