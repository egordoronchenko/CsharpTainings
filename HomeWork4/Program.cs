﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int numberA, numberB,result;

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Deegree(int numberA, int numberB)

    {
        result = 1;
        for (int i = 1; i <= numberB; i++)
        {
            result = numberA * result;

        }
        Console.WriteLine($"число {numberA} в степени {numberB} = {result}");
    }
numberA = ReadInt("Введите число");
numberB = ReadInt("В какую степень возводим:");
Deegree(numberA, numberB);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int numberX, result;
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumOfNumbers(int numberX)
    {
        result = 0;
        while (numberX > 0)
            if (numberX < 10)
            {result = result+numberX;
            return result;
            break;
            }
            else 
            {result = result + numberX%10;
            numberX=numberX/10;
            }
        return result;
    }



numberX = ReadInt("Введите число");
int final = SumOfNumbers(numberX);
Console.WriteLine(final);

