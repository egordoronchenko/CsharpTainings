/*
int ReadInt(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue )
{
    int [,] array  = new int[rows,columns];

    for(int i = 0; i < rows; i++)   
        {
            for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue);  
        }
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] +" ");
            
        }
        Console.WriteLine();
    }
}

int rows = ReadInt("Введи количество строк");
int columns = ReadInt("Input number of columns");
int minValue = ReadInt("min possible value");
int maxValue = ReadInt("max possible value");
int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray (myArray);
*/


//Задать двумерный массив m и n
/*
int ReadInt(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateRandom2dArray (int rows, int columns)
{
    int [,] array  = new int[rows,columns];

    for(int i = 0; i < rows; i++)   
        {
            for(int j = 0; j < columns; j++)
            array[i,j] = i+j;  
        }
    return array;
}


void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] +" ");
            
        }
        Console.WriteLine();
    }
}

int rows = ReadInt("Введи количество строк");
int columns = ReadInt("Input number of columns");
int[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray (myArray);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.


int ReadInt(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue )
{
    int [,] array  = new int[rows,columns];

    for(int i = 0; i < rows; i++)   
        {
            for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue);  
        }
    return array;
}

void Change2dArray (int[,] array)
{
    for(int i = 2; i < array.GetLength(0);i+=2)
    {
        for(int j = 2; j < array.GetLength(1);j+=2)
        {
            array[i,j] = array[i,j]*array[i,j];
            
        }
        
    }
}
void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] +" ");
            
        }
        Console.WriteLine();
    }
}

int rows = ReadInt("Введи количество строк");
int columns = ReadInt("Input number of columns");
int minValue = ReadInt("минимальный");
int maxValue = ReadInt("Максимальный");

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Change2dArray(myArray);
Show2dArray (myArray);