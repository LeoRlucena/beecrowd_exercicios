﻿using System;

namespace URI1019 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);



        }
    }
}