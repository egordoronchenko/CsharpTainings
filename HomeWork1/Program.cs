// //Задача 2
// Console.Write("Введите первое число: ");
// int MisterFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int MisterSecond = Convert.ToInt32(Console.ReadLine());

// if (MisterFirst > MisterSecond)
// {
//     Console.Write("Первое число больше");
// }
// else
// {
//     Console.Write("Второе больше первого");
// }

// // Задача 4

// Console.WriteLine("Введите первое число");
// int Father = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int Son = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите третье число");
// int HolySpirit = Convert.ToInt32(Console.ReadLine());

// int Trinity = Father;

// if (Trinity < Son)
// {
//     Trinity = Son;
// }
// if (Trinity < HolySpirit)
// {
//      Trinity = HolySpirit;
// }

// Console.Write($"Наибольшее из введеных чисел это - {Trinity}");


 //Задача 6

 Console.WriteLine("Введи число");
 int Numerus = Convert.ToInt32(Console.ReadLine());
 int Veritas = Numerus%2;
if (Veritas == 0)
{
    Console.Write ($"Число {Numerus} четное");
}
else
{
    Console.Write("Число "+Numerus+" нечетное");
}