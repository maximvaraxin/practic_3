/*
 *  Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 *  A (3,6); B (2,1) -> 5,09 
 *  A (7,-5); B (1,-1) -> 7,21
 */

namespace App_3
{
    class Programm
    {
        static void Main ( string[] args )
        {   
            Console.WriteLine($"Координаты первой точки:");
            double[] vector_1 = AddCoordanate( 2 );

            Console.WriteLine($"Координаты второй точки:");
            double[] vector_2 = AddCoordanate( 2 ); 
            
            Console.WriteLine($" Расстояние между векторами: { GetLength( vector_1, vector_2 ) } ");
        }
        
        // добавляет координаты точек
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
        
        // возвращает расстояние между ними в 2D пространстве
        static double GetLength( double[] vector_1, double[] vector_2)
        {
            double length = 0;

            length = Math.Sqrt( Math.Pow( ( vector_2[0] - vector_1[0] ), 2 ) + Math.Pow( ( vector_2[1] - vector_1[1] ), 2 ) );

            return Math.Round(length, 2);
        }
    }
}   