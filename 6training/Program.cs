void ReverseArray (int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array [i];
        array [i] = array [array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
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
