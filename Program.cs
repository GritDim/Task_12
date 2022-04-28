using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
                
        
            
            Console.WriteLine("введите радиус окружности");
            Console.Write(" r = ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("Длина окружности круга = ");
            Console.WriteLine(FormulaKrug.DlinaKruga(r));
            Console.Write("Площадь круга = ");
            Console.WriteLine(FormulaKrug.SKruga(r));
            Console.WriteLine();

            Console.WriteLine("Введите координаты центра окружности");
            Console.Write(" x0 = ");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" y0 = ");
            int y0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите координаты точки");
            Console.Write(" x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            FormulaKrug.Koordinati(r,x0,y0,x,y);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }



    }
    static class FormulaKrug
    {
             
            
        public static double DlinaKruga(int r)
        {
           return 2*Math.PI*r;
        }
        public static double SKruga(int r)
        {
            return Math.PI * r * r;
        }
        public static void Koordinati(int r, int x0, int y0, int x, int y)
        {
            double d = Math.Sqrt(Math.Pow(x0 - x, 2) + Math.Pow(y0 - y, 2));
            if (d <= r)
                Console.WriteLine("точка лежит в круге.");
            else
                Console.WriteLine("точка лежит вне круга.");

        }

    }
}



   