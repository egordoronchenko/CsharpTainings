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
/*
int ReadInt(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    for(int i = 0; i < rows;i++)
    {
        for (int j = 0;j < columns;j++)
        {
            array[i,j] = new Random().Next(0, 255);
        }
    }
    return array;
}

void CheckArray(int[,] array, int x, int y)
{
    if(x < 0 && y <0)  Console.WriteLine("Цифры должны быть больше 0");   
    else 
    {
        if(x < array.GetLength(0) && y < array.GetLength(1)) 
        Console.WriteLine($"Значение ячейки {array[x,y]}");
        else  Console.WriteLine("Такой ячейки не существует в массиве");
    }
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");   
int [,] myArray = CreateArray(rows, columns);
int x = ReadInt("Введите строку поиска");
int y = ReadInt("Введите столбец поиска");
CheckArray(myArray, x, y);
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int ReadInt(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows;i++)
    {
        for(int j = 0;j < columns;j++)
        {
        array[i,j] = new Random().Next(1,11);
        }
    }
    return array;
}

void SumColumns(int[,]array)
{
   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0.0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        double result = Math.Round(sum / array.GetLength(0),2);
       Console.Write(result+", ");
    }
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int[,] myArray = CreateArray(rows, columns);
SumColumns(myArray);
