//Задача 1 ввести число. программа выводит сумму чисел от 1 до этого числа
/*
int num, sum;
sum = 0;
int count = 0;
int Sum(int num)
    //int count = 0;
    {
        while (count <= num)
        {
            sum += count;
            count++;

        }
        return sum;
    }

Console.WriteLine("Input a number");
num = Convert.ToInt32(Console.ReadLine());

sum = Sum(num);
Console.WriteLine(sum);
*/

//Задача 2 введите число и возвращает количество цифр в этом числе
/*
int num,result;
int count = 0;
int Zyxel(int num)
{
    //var count = 0;
while(num > 10)
    {
        num = num/10;
        count ++;
    
    }
count ++;
return count;
}
Console.WriteLine("Input a number");
num = Convert.ToInt32(Console.ReadLine());
result = Zyxel(num);
Console.WriteLine(result);
*/



//Задача 3 ввод числа. выводит произведение от 1 до числа

int num, composition;

int Composition(int num)
    {int count = 1;
    composition= 1;
    
     while(count<=num)
     {
        composition = composition*count;
        count++;
     }
     return composition;
    }

num = ReadInt("Input a number");
int result = Composition(num);
Console.WriteLine(result);

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}