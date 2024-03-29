﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void ShowCoordinates(double k1, double b1, double k2, double b2)
{
    Console.Clear();
    Console.WriteLine("заданны уравнения y = k1 * x + b1, y = k2 * x + b2");
    string result;
    if (k1 == k2) result = "Линии параллельны";
    else
    {
        double coorX = (b2-b1)/(k1-k2);
        double coorY = k1*coorX+b1;
        result = $"({coorX}; {coorY})";
    }
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {result}");
}

Console.WriteLine($"Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

ShowCoordinates(k1, b1, k2, b2);


















// // void LineIntersectionCheck(double firstK, double firstB, double secondK, double secondB)
// // {
// //     // k1x+b1=k2x+b2
// //     // k1x-k2x = b2-b1
// //     // x(k1-k2) = b2-b1
// //     // x = (b2-b1) / (k1-k2)
// //     // y = k1 * ((b2-b1) / (k1-k2)) + b1

// //     // double x = (secondB - firstB) / (firstK - secondK);
// //     // double y = firstK * ((secondB - firstB) / (firstK - secondK)) + firstB;
// //     // System.Console.WriteLine($"Координаты пересечения прямых: x = {x}; y = {y};");
// // }
// double firstK=0;
// double firstB=0;
// double secondK=0;
// double secondB=0;
// System.Console.WriteLine("Даны уравнения: y = k1 * x + b1, y = k2 * x + b2");
// System.Console.WriteLine("Введите значения k1, b1, k2, b2 для нахождения точки пересечания прямых на графике");
// System.Console.WriteLine("Введите k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введите b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// if (k1 == k2 && b1 == b2) System.Console.WriteLine("Все точки заданных прямых совпадают. Одна прямая лежит на другой.");
// if (k1 == k2 && b1 != b2) System.Console.WriteLine("Точки пересечения прямых отсутствуют. Прямые, заданные формулами, параллельны и не пересекаются на плоскости");
// // if (k1 != k2) LineIntersectionCheck(k1, b1, k2, b2);
// double x = (secondB - firstB) / (firstK - secondK);
// double y = firstK * ((secondB - firstB) / (firstK - secondK)) + firstB;
// System.Console.WriteLine($"Координаты пересечения прямых: x = {x}; y = {y};");