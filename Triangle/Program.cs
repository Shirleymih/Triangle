using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int width = ReadInt("Enter width: ");
         
            int height = ReadInt("Enter height: ");

            int result = Triangle(width, height);
            Console.WriteLine($"The area is {result}");

            Console.ReadLine();  

        }
        static int Triangle(int width, int height)
        {
            return (width * height) / 2;
        }


        static int ReadInt (string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
