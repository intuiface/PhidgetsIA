using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPhidget
{
    class Program
    {
        static Phidget888.Phidget888 p;

        static void Main(string[] args)
        {
            p = new Phidget888.Phidget888();
            p.Button0Pressed += new EventHandler(p_Button0Pressed);
            p.Button0Released += new EventHandler(p_Button0Released);
            p.Button1Pressed += new EventHandler(p_Button1Pressed);
            p.Button1Released += new EventHandler(p_Button1Released);

            Console.WriteLine("Enter 'q' to quit");
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "q")
                    break;
            }
        }

        static void p_Button1Released(object sender, EventArgs e)
        {
            p.SetOutput(1, false);
        }

        static void p_Button1Pressed(object sender, EventArgs e)
        {
            p.SetOutput(1, true);
        }

        static void p_Button0Released(object sender, EventArgs e)
        {
            Console.WriteLine("Button 0 Released");
            p.SetOutput(0, false);
        }

        static void p_Button0Pressed(object sender, EventArgs e)
        {
            Console.WriteLine("Button 0 Pressed");
            p.SetOutput(0, true);
        }
    }
}
