﻿/* Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());
int max ;

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
};
Console.Write($"max =  {max}");
/* другой вариант решения, сделал его, потому что в начале не разобрался с синтаксисом
if (number1 > number2)
{
    Console.Write("max = ");
   Console.Write(number1);
}
else
{
    Console.Write("max = ");
     Console.Write(number2);
};
*/