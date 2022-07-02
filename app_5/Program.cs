/*
 * Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 *  14212 -> нет
 *  23432 -> да
 *  12821 -> да
 */

namespace App_5
{
    class Programm
    {
        static void Main ( string[] args )
        {   
            Console.Write( $" Введите число: " );
            int num = Convert.ToInt32( Console.ReadLine() );

            string palidrome = ( GetReverse( num ) == num ) ? $" число является палиндромом " : $" число НЕ является палиндромом ";
            
            Console.Write( palidrome );
        }

        static int GetReverse( int number )
        {   
            int result = 0;
            int division;

            while( number > 0)
            {
                division = number % 10;
                
                result = result * 10 + division;
                
                number = number / 10;
            }
            return result;
        }
    }
}   