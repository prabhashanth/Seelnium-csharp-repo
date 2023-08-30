using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Demo3Logics
    {
        public static void Main3(string[] args)
        {

            ////1 to 10
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int[] number = { 10, 50, 60, 78, 20, 4, 8, 9, 10 };
            Console.WriteLine(number.Length);

            //0 to 8
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            //print values that are less than or equal to 50 from the array using for loop

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] <= 50)
                {
                    Console.WriteLine(number[i]);
                }
            }
        }
    }
}
