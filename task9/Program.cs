﻿// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num % 10;
//int b = a % 100; // 10
//int c = num; // 100

Console.WriteLine(a);