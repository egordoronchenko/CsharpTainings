//Задача1

int SecondNumber(int num)
{
     int dozen = num/10;
     int unit = dozen%10;
     return unit;
}
Console.WriteLine("Введите 3х значное число");
int third = Convert.ToInt32(Console.ReadLine());
if (third < 100 ||third>999) 
Console.WriteLine($"{third} не является 3-х значным числом ");

int result = SecondNumber(third);
Console.WriteLine(result);
