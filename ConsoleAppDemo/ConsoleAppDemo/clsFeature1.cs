using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDemo
{
    class clsFeature1
    {
        public void printData()
        {
            Console.WriteLine("This is feature1");
        }

        public int add()
        {
            //changed variable to var from int - online
            var x = 1;
            var y = 2;
            var sum = x + y;
            return sum;
        }
    }
}
