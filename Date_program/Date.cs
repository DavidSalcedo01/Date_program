using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Date_program
{
    internal class Date
    {
        public Date(string Value)
        {
            uint[] splitDate = new uint[3];
            int l = 0;
            string [] split = Value.Split('/');
            for (int i = 0; i < split.Length; i++)
            {
                try
                {
                    splitDate[l] = uint.Parse(split[i]);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("!- Ingrese solo numeros -!");
                    Thread.Sleep(1000);
                    Program.Main();
                }
                catch(OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("!- Ingrese una fecha real -!");
                    Thread.Sleep(1000);
                    Program.Main();
                }
                l++;
            }
            Day(splitDate[0], splitDate[1], splitDate[2]);
        }
        public readonly uint[] month31 = { 1, 3, 5, 7, 8, 10, 12 };
        public readonly uint[] month30 = { 4, 6, 9, 11 };
        private void Day(uint day, uint month, uint year)
        {
            for (int i = 0; i < month31.Length; i++)
            {
                if(month == month31[i])
                {
                    if(day != 0 && day <= 31)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("dia correcto!");
                        Thread.Sleep(1500);
                        Month(month, year);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("dia incorrecto!");
                        Thread.Sleep(1500);
                        Program.Main();
                    }
                }

            }
            for(int l = 0; l < month30.Length; l++)
            {
                if (month == month30[l])
                {
                    if (day != 0 && day <= 30)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("dia correcto!");
                        Thread.Sleep(1500);
                        Month(month, year);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("dia incorrecto!");
                        Thread.Sleep(1500);
                        Program.Main();
                    }
                }
            }
            
            if(month.Equals(2))
            {
                if((year % 4) == 0)
                {
                    if(day != 0 && day <= 29)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("dia correcto!");
                        Thread.Sleep(1500);
                        Month(month, year);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("dia incorrecto!");
                        Thread.Sleep(1500);
                        Program.Main();
                    }
                }
                else
                {
                    if(day != 0 && day <= 28)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("dia correcto!");
                        Thread.Sleep(1500);
                        Month(month, year);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("dia incorrecto!");
                        Thread.Sleep(1500);
                        Program.Main();
                    }
                }
            }

        }
        private void Month(uint month, uint year)
        {
            if (month != 0 && month <= 12)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("mes correcto!");
                Thread.Sleep(1500);
                Year(year);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("mes incorrecto!");
                Thread.Sleep(1500);
                Program.Main();
            }
        }
        private void Year(uint year)
        {
            if ((year % 4) == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("año biciesto!");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("año normal!");
                Console.ResetColor();
            }
        }
    }
}
