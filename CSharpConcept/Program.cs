// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.CSharpConcept
{
    public class Program
    {
        public static void Main1(String[] args)
        {
            Console.WriteLine("Hello, World!");

            byte a = 10; //a is reserved for byte --> 1 byte (8 bits)
            int b = 10; //b is reserved for int --> 4 bytes (32 bits)
            long c = 10;  //8 byte (64 bits)
            char d = 'r'; //16 bits 
            bool check = true;
            float f = 10.2f; //32 bits
            double g = 10.2; //64bits

            Console.WriteLine(a);

            String myName = "prabha";  //6 *16 bits

            long result = b + c;
            Console.WriteLine(result);

            int radius = 10;

            //calculate area of circle and print it
            double pie = 3.14 * radius*radius;
            Console.WriteLine("The result is "+ pie);         

          
            
            String name = "Prabha";
            Console.WriteLine(name[2]);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());

            //5 marks
            int[] numbers = new int[5];
            numbers[0] = 45;
            numbers[1] = 44;
            numbers[2] = 43;
            Console.WriteLine(numbers);
            Console.WriteLine(numbers[1]);

            //red green and yellow
            string[] colors = new string[3];
            colors[0] = "red";
            colors[1] = "yellow";
            //colors[2] = "green";

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            Console.ReadLine();
        }
    }
}

