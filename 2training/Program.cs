// Напишите программу, которая выводит 
// случайное трёхзначное число и 
// удаляет вторую цифру этого числа.


//Задача1
int CutNumber(int num)
{

    int hundreds = num/100;
    int unit =  num%10;

    int result = hundreds*10 + unit;
    return result;
    }

int randomNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}");


