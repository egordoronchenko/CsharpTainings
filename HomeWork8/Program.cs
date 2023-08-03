/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray (int rows, int columns)
{
    
    int[,]  array = new int[rows,columns]; 

    for (int i = 0; i < rows; i++)
    {
        for(int j =0; j < columns; j++)
        {
            array[i,j] = Convert.ToInt32( new Random().Next(0, 99));
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for(int j=0;j < array.GetLength(1);j++)
        {
            for( int k = 0;k < array.GetLength(1)-j-1; k++) 
            {
                if (array[i,k] > array[i,k+1])
                {
                    int change = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = change;
                }
            } 
        }
    }
    return array;
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");

int[,] myArray = CreateArray(rows, columns);
ShowArray(myArray);
int[,] myArray1 = SortArray(myArray);
Console.WriteLine("");
 ShowArray(myArray1);
 */

/* Задача 56: Задайте прямоугольный двумерный массив.
  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

/*
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateArray(int a, int b)
{
    int [,] array = new int[a,b];
    for(int i = 0; i < a;i++)
    {
        for(int j = 0;j < b;j++)
        {
            array[i,j] = Convert.ToInt32(new Random().Next(10, 100));
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0;i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}


int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите колиичество столбцов");
int[,] myArray = CreateArray(rows, columns);
ShowArray(myArray);

NumberRowMinSumElements(myArray);
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

void PrintArray2D(int[,]array)
{
    for (int i = 0;i < array.GetLength(0); i++)
    {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);



// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция заполнения массива рандомными числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

 */
 /*


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/




bool Checking(int[,,] array3d,int number)
{
    bool xyz = false;
    for (int i = 0;i < array3d.GetLength(0);i++)
    {
        for (int j = 0;j < array3d.GetLength(1);j++)
        {
            for(int k = 0;k < array3d.GetLength(2);k++)
            {
            if (number == array3d[i,j,k]) xyz = true;
            }
        }
    }
return xyz;
}


//Создадим и Заполним трехмерный массив
int[,,] array3d = new int[2,2,2];
//array3d[0,0,0] = new Random().Next(10,100);

for(int i = 0;i < array3d.GetLength(0);i++)
{
    for(int j=0;j<array3d.GetLength(1);j++)
    {
        for (int k=0;k<array3d.GetLength(2);k++)
        {
            int num = new Random().Next(10, 100);
        
            bool check = Checking(array3d,num);
            if(check == false)
            {
                array3d[i,j,k] = num;
            } 
            else 
            {
                k--;
            }
        }
    }
}

void Show3DArray(int[,,] array3d)
{
    for(int i = 0;i < array3d.GetLength(0);i++)
    {
        for(int j=0;j<array3d.GetLength(1);j++)
        {
            for (int k=0;k<array3d.GetLength(2);k++)
            {
                Console.Write($"{array3d[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine("");
        }
    }
}
Show3DArray(array3d);
