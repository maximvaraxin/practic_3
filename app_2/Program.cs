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
        
        // возвращает диапазон возможных координат точек в этой четверти
        static string GetQuarter( int quarter)
        {   
            string result = string.Empty;
            string param_x;
            string param_y;

            if( quarter <= 4 )
            {
                switch (quarter)
                {
                    case 1:
                        param_x = " x > 0 ";
                        param_y = " y > 0 ";
                        break;
                    case 2:
                        param_x = " x < 0 ";
                        param_y = " y > 0 ";
                        break;
                    case 3:
                        param_x = " x < 0 ";
                        param_y = " y < 0 ";
                        break;
                    default:
                        param_x = " x > 0 ";
                        param_y = " y < 0 ";
                        break;
                } 
            }
            else
            {
                param_x = " -1 ";
                param_y = " -1 ";
            }
                                 
            return result = $"{ param_x } | { param_y }";         
        }
    }
}   