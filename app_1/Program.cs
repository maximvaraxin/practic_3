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
            Console.WriteLine($"Координаты точки:");
            double[] vector = AddCoordanate( 2 );
            
            string result = ( vector[0] != 0  && vector[1]!= 0 ) ? $" Номер четверти: { SetPoint( vector ) } " : $" Одна из координат должна быть не равна 0!";
            Console.WriteLine( result );
        }

        // добавляет координаты точки
        static double[] AddCoordanate( int len )
        {
            double[] mass = new double[len];

            for (int i = 0; i < mass.Length; i++)
			{   
                Console.Write( $" Введите координату { i + 1 }: " );
                mass[i] = Convert.ToInt32(Console.ReadLine()); 
			}

            Console.WriteLine($"--------------------");

            return mass;
        }
        
        // возвращает номер четверти по установленным координатам
        static int SetPoint( double[] param )
        {
            int result = 0;

            if( param[0] > 0 && param[1] > 0 )
            {
                result = 1;
            }
            else if( param[0] < 0 && param[1] > 0 )
            {
                result = 2;
            }
            else if( param[0] < 0 && param[1] < 0 ) 
            {
                result = 3;
            }
            else
            {
                result = 4;
            }
          
            return result;
        }
    }
}   