﻿using System;

namespace MyApp 
{
     class Program
    {
        static void Main(string[] args)
        {
            
            int[][] array = {
                new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                new int [] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 },
                new int [] { 3, 6, 9, 12, 15,18,21,24,27,30},
                new int [] { 4,8,12,16,20,24,28,32,36,40},
                new int [] { 5,10,15,20,25,30,35,40,45,50},
                new int [] { 6,12,18,24,30,36,42,48,54,60},
                new int [] { 7,14,21,28,35,42,49,56,63,70},
                new int [] { 8,16,24,32,40,48,56,64,72,80},
                new int [] { 9,18,27,36,45,54,63,72,81,90},
                new int [] { 10,20,30,40,50,60,70,80,90,100},
            };

            for (int i = 0; i < array.Length; i++)
            {
                //var str = String.Join(", ", array[i]);
                //Console.WriteLine("[" + str + "]");
                Console.Write("[");
                for (int j = 0;j<array[i].Length;j++){
                    Console.Write(array[i][j] + "\t");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}

