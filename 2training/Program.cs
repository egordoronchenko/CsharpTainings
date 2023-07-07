// // Напишите программу, которая выводит 
// // случайное трёхзначное число и 
// // удаляет вторую цифру этого числа.


//Задача1

// int CutNumber(int num)
// {

//     int hundreds = num/100;
//     int unit =  num%10;

//     int result = hundreds*10 + unit;
//     return result;
//     }

// int randomNumber = new Random().Next(100,1000);

// int newNumber = CutNumber(randomNumber);
// Console.WriteLine($"New version of {randomNumber} is {newNumber}");


// //Задача3

// bool IsDividable (int num, int a, int b )
// {
//     if (num % a == 0 && num b == 0) 
//         return true;
//     else 
//         return false;
// }

// Console.WriteLine("Input a number for checking: ");
// int number = Convert.ToInt32(Console.ReadLine);
// Console.WriteLine("Input a first divider: ");
// int div1 = Convert.ToInt32(Console.ReadLine);
// Console.WriteLine("Input a second divider: ");
// int div2 = Convert.ToInt32(Console.ReadLine);

// bool result = IsDividable(number, div1, div2);
// Console.WriteLine(result);

//задача 5
/*
int BigNumber(int num)
{
    int dozens = num/10;
    int unit   = num%10;

    if (dozens > unit) return dozens;
    else return unit;

}

int randomNumber = new Random().Next(10,100);

int newNumber = BigNumber(randomNumber);
Console.WriteLine(randomNumber);
Console.WriteLine(newNumber);
*/


bool QuadResult (int num1, int num2)
{
    if ( num1==num2*num2||num2 == num1*num1) return true;
    else return false;
}

Console.Write("input first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = QuadResult(firstNumber, secondNumber);
Console.Write(result);

