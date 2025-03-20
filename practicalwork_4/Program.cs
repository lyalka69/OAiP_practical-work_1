﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задание №1. Написать программу, которая вычисляет значение функции у:
            //double x, y;
            //Console.WriteLine("x: ");
            //x = double.Parse(Console.ReadLine());

            //if (x >= 10)
            //{
            //    y = 4 + Math.Pow(x, 2) - Math.  Exp(Math.Sqrt(x));
            //}
            //else
            //{
            //    y = 3.4 - x + 0.1 * Math.Pow(x, 3);
            //}

            //Console.WriteLine($"y & x = {x} & {y}");

            ////Задание №2. Написать программу, которая определяет: является ли заданное целое число четным.
            //Console.Write("Введите целое число: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} является четным");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} является нечетным");
            //}

            //Дана точка на плоскости с координатами (х, у). Составить программу,
            //которая выдает одно из сообщений "Да", "Нет", "На границе" в зависимости от того,
            //лежит ли точка внутри заштрихованной области, вне заштрихованной области или на ее границе. 
            //Области задаются графически следующим образом:

            Console.Write("Введите координату x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y: ");
            double y = double.Parse(Console.ReadLine());
            double radiusSquared = 81; // 9^2
            double distSquared = x * x + y * y;// Уравнение окружности: x^2 + y^2 = 9^2, и область лежит в правой полуплоскости (x >= 0)

            if (x >= 0 & distSquared < radiusSquared & y >= 0)
            {
                Console.WriteLine("Да");
            }
            else if (x >= 0 & distSquared == radiusSquared & y >= 0)
            {
                Console.WriteLine("На границе");
            }
            else
            {
                Console.WriteLine("Нет");
                Console.ReadKey();


            }
    }
}
