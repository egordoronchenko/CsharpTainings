/*
void ReverseArray (int [] array)
{
    for (int i = 0, j = array.Length-1; i < j / 2; i++, j--)
    {
        int temp = array [i];
        array [i] = array [j];
        array[j] = temp;
    }

}

int ReadInt(string messege)
{
    Console.WriteLine (messege);
    return Convert.ToInt32(Console.ReadLine());
}

int [] CreateArray (int Length, int minValue, int maxValue)
{
    int [] array = new int [Length];
    for(int i = 0; i < Length;i++)
    {
       array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        Console.Write($"{array[i]}, ");
    }
Console.WriteLine();
}

int size = ReadInt("Введите размер массива");
int minValue = ReadInt("Введите минимальное число массива");
int maxValue = ReadInt("Введите максимальное число массива");

int[] myArray = CreateArray(size, minValue, maxValue);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

//Задача 1
int ReadInt(string messege)
{
    Console.WriteLine (messege);
    return Convert.ToInt32(Console.ReadLine());
}

int [] CreateArray ()
{
    int [] array = new int [3];
    for(int i = 0; i < 3;i++)
    {
       array[i] = ReadInt($"Введите длину стороны {i+1}");
    }
    return array;
}

bool Triangle (int[] array)
{
    if(array[0]>(array[1]+array[2])&&array[1]>(array[0]+array[2])&&array[2](array[0]+array[1]))
    return true;
    else return false;
}

int [] myArray = CreateArray();
bool x = Triangle(myArray);
Console.WriteLine (x);