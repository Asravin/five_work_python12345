﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Ведите значения  b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите значения  b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите значения  k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите значения  k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double straight0 = -(b1 - b2) / (k1 - k2);
double straight1 = (k2 * straight0) + b2;

Console.WriteLine($"({straight0}) : ({straight1})");