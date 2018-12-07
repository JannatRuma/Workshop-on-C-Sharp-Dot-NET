using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //console is a  class of system namespace

            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //backgroungColor property set background color 

           // Console.ForegroundColor = ConsoleColor.Green;
            //ForegroundColor set text color

            //ConsoleColor col = Console.BackgroundColor;
            //ConsoleColor col1 = Console.ForegroundColor;

            //Console.CursorSize = 100;
            //set cursor depth

            //Console.Beep(2100,1000);
            //beep(int frequency,int milisecond)

            //Console.WriteLine(col);
            //Console.Write(col1);
            //Writeline can write any variables in n line 

           // Console.WriteLine(100);

           Console.SetWindowSize(200, 50);
            //SetWindowSize(width,height);

           Console.Write(20008978675);

            //Console.Clear();
            //clear will clear the screan

            Console.ReadKey();
            //Console.ReadKey();

            //waiiting for a key
        }
    }
}
