﻿/* : Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");

double number = Convert.ToDouble(Console.ReadLine());
//double a = number % 2;
if (number % 2 == 0) 
{
    Console.Write("Da");
}
else
{
    Console.Write("Net");
}
/*
if (number % 2 != 0);
{
Console.Write("net");
}
*/