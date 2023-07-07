//Задача1
/*
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
*/

//Задача2 
/*
int SempleSolution(int num)
{
    while (num >999)
    {
        num = num/10; 
    }
int result = num%10;
return result;    

}


Console.WriteLine("Введите число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber <100) 
{
    goto Found;
}


Console.WriteLine(SempleSolution(threeDigitNumber));
Found:
    Console.WriteLine($"число {threeDigitNumber} двузначное. Третьей цифры нет");
    */


String Weekend(int num )
{
    String hol = "выходным";
    String job = "рабочим";
    
        if(num%6==0||num%7==0) return hol;
        else return job;

}


Console.WriteLine("Введите день недели");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek > 7) Console.WriteLine("Так то в неделе 7мь дней. ну да ладно");

String result = Weekend(dayOfWeek);
Console.WriteLine($"{dayOfWeek} является {result} днем");