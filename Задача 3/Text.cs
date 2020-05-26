using System;
using System.Linq;

namespace Задача_3
{

    /*Задача. 3
        Създайте програма, която от въведен текст изкарва думите които се повтарят нечетен брой пъти
        Вход:
        java C# php PHP JAVA C java
        Изход:
        java, c#, c
    */

    class Text
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дадените думи: ");
            string[] text = { "java", "C#", "php", "PHP", "JAVA", "C", "java" };
           
            for (int s = 0; s < text.Length; s++)
            { 
                Console.Write(text[s]+ " " );
            }

            Console.WriteLine();
            Console.WriteLine("\nДумите, които се повтарят нечетен брой пъти, са: ");
            
            for (int i = 0; i < text.Length; i++)
            {
                    int count = 0;

                    for (int j = 0; j < text.Length; j++)
                    {
                        if (text[i].ToLower() == text[j].ToLower())
                        {
                            count++;  
                        }
                    }

                    if (count % 2 == 1 )
                    {
                        Console.Write(text[i].ToLower() + " " );
                        text[i] = "-";
                        
                    }
            }

            Console.WriteLine();
        }
    }

}