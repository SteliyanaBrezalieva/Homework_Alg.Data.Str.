using System;

namespace Задача_4

{
    class Array
    {
       
        /*Задача. 4
            На случаен принцип се генерира масив от 10 елемента които са от целочислен тип.
            A)Напишете метод, който пресмята средната стойност на масива.(Сумата на елементите делена на
            броя елементи)
            Б)Напишете метод, който проверява дали дадено число се съдържа в масива. Метода връща индекса, 
            ако има такова число и -1, ако го няма.
            В)Напишете метод, който прехвърля стойностите от масив А в масив Б.
            Е)Напишете метод, който намира 2рия най - малък елемент на масива (Без да го сортираме)

          */       
    
            public int AverageSum(int[] array)
            {
                int sum = 0;
                int averageSum = 0; // double averageSum = 0.0
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i]; //sum = sum + array[]
                }
                return averageSum = (sum / 2);
            }


            public int Contains(int[] array, int item)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (item.Equals(array[i]))
                    {
                       return i;
                    }
                   
                }
                
                       return -1;
            }




            public  void CopyArray(int[] array)
            {
              int[] tempArray = new int[array.Length];
              
                for ( int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                    Console.Write(tempArray[i] + " ");
                }        
            }


            public void SmallElement(int[] array)
            {
                int small = array[0];
                int small2 = int.MaxValue;

            for (int i = 1; i < array.Length; i++)
            {  
                if (small > array[i])
                {
                    small2 = small;
                    small = array[i];

                }
                else if (small2 > array[i] && array[i] != small) 
                {
                     small2 = array[i];
                }
            }
               Console.WriteLine(small2);
            }




        static void Main(string[] args)
            {

                Random rand = new Random();
                int[] arr = new int[10];
                int i;
                Console.WriteLine("Елементите на масива: ");
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1,101);
                    Console.Write(arr[i]+ " ");
                }
            
               
                Array n = new Array();
                Console.WriteLine();
                Console.WriteLine("\nСредната стойност на масива е : " + n.AverageSum(arr));

                Console.Write("\nТърсеният елемент е на позиция: ");
                Console.WriteLine(n.Contains(arr, 10));

                Console.WriteLine();
                n.CopyArray(arr);

                Console.WriteLine();
                Console.Write("\nВторият малък елемент е: ");
                n.SmallElement(arr);
                  
        }
    }
}
