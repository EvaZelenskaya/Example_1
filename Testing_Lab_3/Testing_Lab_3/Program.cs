using System;

namespace Testing_Lab_3
{
    class lab_3
    {
        static void Main(string[] args)
        {
            logic_B see2 = new logic_B();
            Console.WriteLine("\r\n///////////////// Задание Б (C#) //////////////////// ");
            see2.logic_();

            Console.ReadKey();
        }
    }
   
    class logic_B
    {
        double y, x, d, c;
        public void logic_() // метод
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

                if (y == 0 && x >= 0 && x <= d) // 1 область
                {
                    Console.Write("ОБЛАСТЬ №1: ");
                    Console.WriteLine("X = " + x + "; Y = " + y);

                }

                else if (x<=0 && x >= -d && y==(-d*x+c)) // 2 область
                {
                    Console.Write("ОБЛАСТЬ №2: ");
                    Console.WriteLine("X = " + x + "; Y = " + y);

                }

                else if (x < -d && y == c) // 3 область
                {
                    Console.Write("ОБЛАСТЬ №3: ");
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
