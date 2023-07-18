//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int length;
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0;i < length;i++)
        {
            array[i] = new Random().Next(100, 1000);            
        }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0;i < array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int SumEvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 0 ;i < array.Length; i++)
    {
        if(array[i]%2==0)
        {
            sum++;
        }
    }
    return sum;
}

length = ReadInt("Введите размер массива");

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);
int show = SumEvenNumber(myArray);
Console.WriteLine(show);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateRandomArray (int length)
{
    int[] array = new int[length];
    for (int i = 0;i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void ShowArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
    Console.WriteLine();
}

int SumEvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 1;i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int length = ReadInt("Введите размер массива");
int[] myArray = CreateRandomArray(length);
ShowArray(myArray);
int sum = SumEvenNumber(myArray);
Console.WriteLine(sum);
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double ReadDouble(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToDouble(Console.ReadLine());
}
int ReadInt(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}
double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = ReadDouble("Введите вещесственное число");
    }
    return array;
}
double Difference(double[] array)
{ 
   int i = array.Length-1;
   double result = array[i] - array[0];
   return result;

}

void ShowArray(double[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
    Console.WriteLine();
}

int size = ReadInt("Введите размер массива");
double[] myArray = CreateArray(size);
ShowArray(myArray);
double difference = Difference(myArray);
Console.WriteLine();
Console.WriteLine($"Разница между последним и первым индексом массива = {difference}");

