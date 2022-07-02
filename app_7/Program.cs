/*
 *  Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 *  3 -> 1, 8, 27
 *  5 -> 1, 8, 27, 64, 125
 */

namespace App_7
{
    class Programm
    {
        static void Main ( string[] args )
        {   
            Console.Write( $" Введите число N: " );
            int num = Convert.ToInt32( Console.ReadLine() );

            MathPowCounter( num );
        }

        // возвращает таблицу кубов чисел от 1 до N
        static void MathPowCounter( int number )
        {
            int counter = 1;

            if( number >= counter )
            {
                Console.Write( $" Таблица кубов чисел от 1 до N: ");
           
                while( number >= counter )
                {
                    Console.Write( $"{ Math.Pow( counter, 3) } ");
                    counter++;
                }
            }
            else
            {
                Console.WriteLine( $" error: N > 0  " );
            }          
        }
    }
}   