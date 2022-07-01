/*
 * Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
 */

namespace App_2
{
    class Programm
    {
        static void Main ( string[] args )
        {   
            Console.Write( $" Введите номер четверти: " );
            int quarter = Convert.ToInt32( Console.ReadLine() ); 
            
            Console.WriteLine($" Диапазон возможных координат точек в этой четверти: { GetQuarter( quarter ) } ");
        }

        static string GetQuarter( int quarter)
        {   
            string result = string.Empty;
            Range param_x;
            Range param_y;

            
            if ( quarter == 1 )
            {   
               param_x = 0..90;
               param_y = 0..90;
            }
            else if ( quarter == 2 )
            {
               param_x = 0..90;
               param_y = 0..-90;
            }
            else if ( quarter == 3 )
            {
               param_x = 0..-90;
               param_y = 0..-90;
            }
            else if( quarter == 4 )
            {
               param_x = 0..-90;
               param_y = 0..90;
            }
            
            return result = $"{param_x} {param_y}";
            
        }
    }
}   