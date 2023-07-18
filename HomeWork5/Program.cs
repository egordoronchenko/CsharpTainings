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

