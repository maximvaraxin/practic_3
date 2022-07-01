/*
 * 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
 * в которой находится эта точка.
 */

namespace App_1
{
    class Programm
    {
        static void Main ( string[] args )
        {   
            Console.Write( $" Введите координату х: " );
            int param_x = Convert.ToInt32( Console.ReadLine() ); 
            
            Console.Write( $" Введите координату y: " );
            int param_y = Convert.ToInt32( Console.ReadLine() );
            
            Console.WriteLine($" Номер четверти: { SetPoint( param_x, param_y ) } ");
        }

        static int SetPoint( int x, int y )
        {
            int result = 0;

            if ( x > 0 && y > 0)
            {
                result = 1;
            }
            else if ( x < 0 && y < 0)
            {
                result = 3;
            }
            else if ( x > 0 && y < 0)
            {
                result = 2;
            }
            else if(x < 0 && y > 0 )
            {
                result = 4;
            }

            return result;
        }
    }
}   