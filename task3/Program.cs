﻿ // 3. По заданному номеру дня недели вывести его название

Console.Clear();

Console.Write("Введите число от 1 до 7: ");
string number = Console.ReadLine();

if(number == "1")
{
    Console.WriteLine("Понедельник - день тяжелый :)");
}

if(number == "2")
{
    Console.WriteLine("Вторник");
}

if(number == "3")
{
    Console.WriteLine("Среда");
}

if(number == "4")
{
    Console.WriteLine("Четверг");
}

if(number == "5")
{
    Console.WriteLine("Пятница");
}

if(number == "6")
{
    Console.WriteLine("Суббота");
}

if(number == "7")
{
    Console.WriteLine("Воскресенье");
}