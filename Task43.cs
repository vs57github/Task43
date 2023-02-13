
using System;

namespace IntersectionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter b1:");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter k1:");
            double k1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b2:");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter k2:");
            double k2 = double.Parse(Console.ReadLine());

            if (k1 == k2)  // прямые параллельны, точки пересечения нет 
                Console.WriteLine("Lines are parallel, no intersection point"); 

            else  // прямые непараллельны, вычисляем точку пересечения 
            {   // x = (b2 - b1) / (k1 - k2)   y = k1 * x + b1 

                double x = (b2 - b1) / (k1 - k2);   // x-координата точки перссчения 

                double y = k1 * x + b1;             // y-координата точки перссчения

                Console.WriteLine($"Intersection point: ({x}; {y})");   //выводим точку перссчения  
            }            

        }        
    }    
}