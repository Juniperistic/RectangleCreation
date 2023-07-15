using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10ex3
{
    class Program
    {
        static void Main(string[] args)
        {
             //Rectangle rect = new Rectangle(); //if you want to use a floating number you must include the f
             //Console.WriteLine(rect);

             //Console.ReadLine();

            //tried to get the try-catch loop to work with the program but was unable to get it to work
            try
            {
                Rectangle rect1 = new Rectangle(10, 0); //invalid values
                Console.WriteLine(rect1);
                Console.ReadLine();
                
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while creating Rectangle1");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            }
        
    }
}
