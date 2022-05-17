using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd
{
    class Program
    {



        static void second()
        {
           
            Console.WriteLine("my name ");

            third();
        }
        static void third()
        {
            Console.WriteLine(" BCA ");
            second();

        }

        static void Main(string[] args)
        {

            second();
            third();

            Console.ReadLine();
        }

    }
}