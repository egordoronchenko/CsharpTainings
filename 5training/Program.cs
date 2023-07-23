//Задайте массив из 12 элементов, заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*cl
int sum;
int ReadInt (string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] CreateRandomArrow(int size,int minValue,int maxValue)

{
    int[] array = new int[size];
        for(int i = 0; i < array.Length;i++)
        {
            array[i] = new Random().Next(minValue, maxValue+1);
        }
        return array;
}

int NegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0;i < array.Length;i++) 
        if (array[i] < 0)
        {
         sum += array[i];
        }
        return sum;
}
int size = ReadInt("введите ");
int minValue = ReadInt("ddtlbnt -9");
int maxValue = ReadInt("введите 9");
int[] myArray =CreateRandomArrow(size, minValue, maxValue);
sum = NegativeSum(myArray);
Console.WriteLine(sum);
*/

//Напишите программу замена элементов
// массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int ReadInt (string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] CreateRandomArrow(int size,int minValue,int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] =new Random().Next(minValue,maxValue);
        Console.WriteLine(array[i]);
    }
return array;

}
void ChangeArray(int[] array)
   {
     for(int i = 0; i < array.Length;i++)
    {
        array[i]= -1*array[i];
        Console.WriteLine(array[i]);
    }    
   }
int size = ReadInt("Введите размер массива");
int minValue = ReadInt("Введите минимальное отрицательно число");   
int maxValue = ReadInt("Введите максимальное число в массиве");

int[]myArray = CreateRandomArrow(size, minValue, maxValue);
ChangeArray(myArray);



















//Задайте массив. 
//Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Задайте одномерный массив из m случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b].