﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Введите а: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер операции: 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {

            }
        }
    }
}
