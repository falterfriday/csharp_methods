using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusable_code_with_methods
{
    class Program
    {

        const int Val1 = 12;
        const int Val2 = 24;

        static void Main(string[] args)
        {
            int total = Add(Val1, Val2);
            Console.WriteLine("Total: " + total);

            int result;
            AddToOutParam(Val1, Val2, out result);
            Console.WriteLine("The Answer is: " + result);
        }

        //takes in 2 integers, returns a integer
        static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        //takes in 3 integers, but doesn't return anything
        //instead, it modifies the out integer
        static void AddToOutParam(int value1, int value2, out int result)
        {
            result = value1 + value2;
        }
    }
}
