﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int Sum(int num)
{
    if ( num < 0)
    num = Math.Abs(num);
     int sum = 0;
    while (num % 10 > 0)
    {

        sum = sum + num % 10;
        num  = num / 10;
    
    }
return sum;
}
Console.WriteLine("Сумма всех цифр в числе равна " + Sum(number));
