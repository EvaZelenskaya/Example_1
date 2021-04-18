using System;
using System.IO;
namespace Testing_for_2._10

{
 class Program
        {
      static void Main(string[] args)
       {
                double x, y;
                string k;
                string[] str = File.ReadAllLines(@"input.txt");
                try
                {
                    x = Convert.ToDouble(str[0]); // x 
                    y = Convert.ToDouble(str[1]); // y 
                    StreamWriter sr = new StreamWriter(@"output.txt");
                    if (((x< -1* Math.Sqrt(-y+2)) && y>0 ) || ((x > Math.Sqrt(-y + 2)) && y>x) ) //// A+
                    {
                        k = "--->Координата принадлежит области A ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if (x<=0 && x>= -1*Math.Sqrt(-y + 2) && y<0 && y>= x) //// F+
                    {
                        k = "--->Координата принадлежит области F ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if ((x <-1* Math.Sqrt(-y + 2)) && y<= 0 && y>x) //// B+
                    {
                        k = "--->Координата принадлежит области B ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if (x>Math.Sqrt(-y + 2) &&  y<0) //// C+
                    {
                        k = "--->Координата принадлежит области C ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if (x<= Math.Sqrt(-y + 2) && x>=-1*Math.Sqrt(-y + 2)&& y<x && y<0) //// D+
                    {
                        k = "--->Координата принадлежит области D ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if (x<= Math.Sqrt(-y + 2) && x>= -1* Math.Sqrt(-y + 2) && y>=0 && y>= x) //// E+
                    {
                        k = "--->Координата принадлежит области E ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if (x>=0 && x<= Math.Sqrt(-y + 2) && y>0 && y<x) //// G+
                    {
                        k = "--->Координата принадлежит области G ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else if ((x > Math.Sqrt(-y + 2) )&& y>=0 && y<x) //// H+
                    {
                        k = "--->Координата принадлежит области H ";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    else
                    {
                        k = "--->Координата не принадлежит ни  одной области";
                        sr.WriteLine("y = " + y.ToString() + " and  x = " + x.ToString() + k);
                    }
                    sr.Close();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректное значение. Замените на число!");
                }
            }
        }
    }


