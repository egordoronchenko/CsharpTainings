

int t, r;
int sum = 0;
bool IsPalindrom(int number)
    { for(t=number;number!=0;number=number/10)
        {
        r=number % 10;
        sum=sum*10+r;
        }
            if(t==sum)
            return true;
            else
            return false;
    } 

Console.WriteLine("Input a number");
link1:
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number <100000  )
    {bool result = IsPalindrom(number);
        if (result == true)
        Console.WriteLine("Палиндром");
        else Console.WriteLine("Число не палиндром");
     }
else
    {Console.WriteLine("число не пятизначное. Введите новое число");
    goto link1;
    }



