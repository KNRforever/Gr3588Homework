﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//просим ввсети число положительное более 1
Console.WriteLine("введите число более 1");

//Считываем число с консоли
string? Lnum = Console.ReadLine(); 

//проверяем число не пустое
if(Lnum!=null)
{
    
    //переводим ввёденное в численный формат
    int num = int.Parse(Lnum);
    int i = 2;

//проверяем что чило более 1
    if(num>1)
    {
        while (num>=i) 
        {
            Console.Write($"{i},");
            i = i + 2;
        }

    }

    
    else Console.WriteLine("вы ввели число менее или равно 1");

}


