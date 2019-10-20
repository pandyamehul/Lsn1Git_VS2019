using System;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World!");
            Console.WriteLine("Changed after commit");
            Console.WriteLine("Code Edited to online");
            Console.WriteLine("Code Edited again online");
            Console.WriteLine("Code changed in VS 2019");

            //added code for feature# 1
            clsFeature1 feature1 = new clsFeature1();
            feature1.printData();

            //added code to call feature# 2
            
            //added code here to call feature# 3
        }
    }
}
