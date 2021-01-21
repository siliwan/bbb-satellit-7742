using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_403_7742_L
{
    // --------------------------------------------
    // Datei:			Program.cs
    // Datum:			30.11.2018
    // Ersteller:		**REDACTED**
    // Version:		    	1.0
    // Änderungen:		-
    // Beschreibung:
    // Rechnet die Umlaufzeit mit einer Höhe von einem Satelliten aus.
    // --------------------------------------------

    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            const Int32 Re = 6378137;
            const double g = 9.81;
            const Int32 minHeight = 20;

            double douHeight;
            double douTimeSec;
            double douTimeHours = 0;

            while (true)
            {
                // 20'000 meter ~ 11.3 h
                try
                {
                    Console.Write("Geben Sie die Höhe des Satelliten in Kilometern an: ");
                    douHeight = Convert.ToDouble(Console.ReadLine());
                    if(douHeight < minHeight)
                    {
                        throw new Exception("Die Mindesthöhe beträgt 20 KM");
                    }
                    douTimeSec = 2 * PI / Re * (Math.Pow((Math.Pow((Re + douHeight * 1000), 3) / g), 0.5));
                    douTimeHours = douTimeSec / 3600;
                    break;
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Zeit: " + douTimeHours + " Stunden");
            Console.ReadKey();
        }
    }
}
