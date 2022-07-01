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
            Console.Write( $" Введите число: " );
            double num = Convert.ToInt32( Console.ReadLine() );

            GetSqrt( num );
        }

        static void GetSqrt( double number )
        {
            double counter = 1;

            Console.Write( $" Результат: ");
           
            while( number >= counter )
            {
                Console.Write( $"{ counter * counter } ");
                counter++;
            }
        }
    }
}   