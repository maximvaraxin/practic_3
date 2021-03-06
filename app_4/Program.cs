/*
 *  Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
 *  5 -> 1, 4, 9, 16, 25.
 *  2 -> 1,4
 */

namespace App_4
{
    class Programm
    {
        static void Main ( string[] args )
        {   
            Console.Write( $" Введите число N: " );
            int num = Convert.ToInt32( Console.ReadLine() );

            MathPowCounter( num );
        }

        // возвращает таблицу квадратов чисел от 1 до N
        static void MathPowCounter( int number )
        {
            int counter = 1;

            if( number >= counter)
            {
                Console.Write( $" Таблица квадратов чисел от 1 до N: ");
           
                while( number >= counter )
                {
                    Console.Write( $"{ Math.Pow( counter, 2) } ");
                    counter++;
                }
            }
            else
            {
                Console.WriteLine( $" error : N > 0 " );
            }          
        }
    }
}   