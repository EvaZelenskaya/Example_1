using System;

namespace Testing_Lab_3
{
    class lab_3
    {
        static void Main(string[] args)
        {
            Class see = new Class();
            Console.WriteLine("\r\n///////////////// Задание Б (C#) //////////////////// ");
            see.zadaniye();

            Console.ReadKey();
        }
    }
   
    class Class
    {
        double y, x, d, c, a;
        public void zadaniye() // метод
        {
            try
            {

                Console.Write("Введите х - ");

                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите y - ");

                y = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Введите d - ");

                d = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите c - ");
               
                c = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Введите a - ");

                a = Convert.ToDouble(Console.ReadLine());


               if ((x == -(y + c) ) && y == -x - c && -c < y )  // 1 область+
                {
                    Console.Write("ОБЛАСТЬ №1: ");
                    Console.WriteLine("X = " + x + "; Y = " + y);

                }

                else if ((x<=0   &&    x>=-d )    &&    y==-c) // 2 область+
                {
                    Console.Write("ОБЛАСТЬ №2: ");
                    Console.WriteLine("X = " + x + "; Y = " + y);

                }

                else if (x<=y+c    &&   x>0    &&   y ==x-c  &&   -c<y   &&   y<= a)  // 3 область ++
                {
                    Console.Write("ОБЛАСТЬ №3: ");
                    Console.WriteLine("X = " + x + "; Y = " + y);

                }
                else if (x>a+c  &&  y==a)  // 4 область ++
                {
                    Console.Write("ОБЛАСТЬ №4: ");
                    Console.WriteLine("X = " + x + "; Y = " + y);

                }

                else // нерассматриваемая область 
                {

                    Console.WriteLine("X = " + x + "; Y = " + y + "  не принадлежат рассматриваемой области");

                }

            }
            catch
            {
                Console.WriteLine("Значения записаны некорректно");
            }

        }

    }

}
