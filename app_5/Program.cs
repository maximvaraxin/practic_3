/*
 * Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 *  14212 -> нет
 *   23432 -> да
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

            GetSqrt( num );
        }

        static void Palindrome( int number )
        {
            int counter = 1;



            Console.Write( $" Результат: ");
        }
    }
}   