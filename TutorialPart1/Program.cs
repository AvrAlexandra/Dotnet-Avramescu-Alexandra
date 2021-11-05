using System;

namespace TutorialPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Program myProgram = new Program();
            myProgram.Print();
            //input
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " ! ");
            Console.WriteLine($"Hello {name} !");
            //variable
            int x = 5;
            Console.WriteLine(x);
            string y = "Ale";
            Console.WriteLine("My name is " + y);

            int z; //declaration
            z = 5; //initialization
            Console.WriteLine(z);

            int? w = null;
            Console.WriteLine(w);

            //Simple Data Types
           // uint a = 5; //only positive numbers
            // char,float,double,decimal...

            int[] array1 = { -5 };
            int[] array2 = array1;
            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);

            array1[0] = 10;

            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);

            int[] array3 = { -6 };
            Test(array3);
            Console.WriteLine(array3[0]);
        }
        void Print() 
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Best Friend");
        }

        static void Test(int[] array) 
        {
            array[0] = 100;
        }
    }
}
