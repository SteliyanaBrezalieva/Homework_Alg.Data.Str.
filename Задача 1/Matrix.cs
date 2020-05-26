
using System;

namespace Задача_1
{
    class Matrix
    {

        /*Задача. 1
              Даден е масив [5,5] от целочислени стойности. 
              Да се намери минималния елемент от всеки стълб.
              От минималните елементи да се намери реда в който е най - малкия (K).
              В нов масив да се запише за всеки минимален елемент I-J*K
              K - Реда в който е минималния елемент;
        */

        public static void Display2Darray(int[,] arr)
        {
           Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   
                    arr[i, j] = rand.Next(10, 100);
                    Console.Write(arr[i,j] + " ");
                   
                }

                Console.WriteLine(" ");
            }
        }


        /*public static int MinElement(int[,] arr)
        {
            int minElement = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElement > arr[i, j])
                    {
                        minElement = arr[i, j];
                    }

                }
               
            }
            return minElement;
        }*/

        public static void MinElementY(int[,] arr)
        {
           
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                int minY = arr[0, y]; // първи елемент от всеки стълб

                for (int x = 1; x < arr.GetLength(0); x++)
                {
                    if(minY > arr[x,y])
                    {
                        minY = arr[x,y];
                    }
                   
                }
                Console.WriteLine("Мин.Елемент от " + (y + 1) + " стълб e: " + minY );
               
               
                
            }
            
        }

        public static void MinElementX(int[,] arr)
        {
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                int minX = arr[x, 0]; // мин.елемент приемаме да е първият от всеки ред
                for (int y = 1; y < arr.GetLength(1); y++)
                {   
                    if(minX > arr[x, y])
                    {
                        minX = arr[x, y];
                    }

                }
                Console.WriteLine("Мин.елемент от " + (x+1) + " ред е : " + minX);
            }
        }

            static void Main(string[] args)
            {
            int[,] arr = new int[5, 5];
           /* {
                    { 11, 13, 13, 27, 10 },
                    { 20, 28, 23, 26, 11 },
                    { 34, 25, 12, 34, 41 },
                    { 12, 34, 19, 37, 23 },
                    { 12, 15, 79, 32, 24 }
            }; */

                Display2Darray(arr);
                Console.WriteLine();
                MinElementY(arr);
                Console.WriteLine();
                MinElementX(arr);

            //  Console.WriteLine("Най-малкият елемент е : ");
            // MinElement(arr);


        }
        
    }
}