using System;
using System.IO;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string k;
            string[] str = File.ReadAllLines(@"in.txt");
            try
            {
                x = Convert.ToDouble(str[0]); //  считывает значение в переменную x 
                y = Convert.ToDouble(str[1]); // считывает значение в переменную y 
                StreamWriter sr = new StreamWriter(@"out.txt");
                if ((y >= -x && x <= 0 && x >(-1* Math.Sqrt(y + 2))) || (y >x  && x>0 && x< Math.Sqrt(y+2))) //// A++
                {
                    k = " - эта точка принадлежит A ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }


                else if ((y > 0 && y < - x) && (x > (Math.Sqrt(y+2)*(-1)) &&  x<0)) //// B++
                {
                    k = " - эта точка принадлежит B ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }
                else if (((x >= (-1 * Math.Sqrt(y + 2))) && x <0) && (y <= 0 && y >=x)) //// C++

                {
                    k = " - эта точка принадлежит C ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }
                else if (((x >= (-1 * Math.Sqrt(y + 2))) && (x <= (Math.Sqrt(y + 2)))) && (y < -x && y >= (Math.Pow(x,2) -2))) //// D++
                {
                    k = " - эта точка принадлежит D ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }

                else if ((x >= 0 && (x <=  Math.Sqrt(y + 2))) && (y >= 0 && y <= x)) //// E++
                {
                    k = " - эта точка принадлежит E ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }
                else if ((y > 0 && y<x) && (x>  Math.Sqrt(y + 2))) //// F++
                {
                    k = " - эта точка принадлежит F ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }

                else if ((x>=0 && x<=-y) && (y <= -x && y < (Math.Pow(x, 2) - 2))) //// G++

                {
                    k = " - эта точка принадлежит G ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }

                else if ((x < (-1 * Math.Sqrt(y + 2))) && (y < 0 && y > x)) //// H++
                {
                    k = " - эта точка принадлежит H ";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }

                else
                {
                    k = " - эта точка не принадлежит ни одной области !";
                    sr.WriteLine("x = " + x.ToString() + " and  y = " + y.ToString() + k);
                }
                sr.Close();
            }
            catch (FormatException)
            {
                Console.WriteLine("Вводимые значения некорректны. Измените числа в файле!");
            }
        }
    }
}
