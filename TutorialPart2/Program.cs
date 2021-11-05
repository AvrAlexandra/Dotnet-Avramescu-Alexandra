using System;
using System.Collections.Generic;

namespace TutorialPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = (int)5.9999999;
            Console.WriteLine(x);

            //Float,double,decimal
            float y = 5.5f;
            double z = 5.5;
            decimal w = 10.5M;
            Console.WriteLine(y + " " + z + " " + w);

            double a = Math.Pow(9999,9999999);
            Console.WriteLine(double.IsInfinity(a));


            //Math Class
            double b = 50.9;
            double c = 60;
            Console.WriteLine(Math.Round(b));
            Console.WriteLine(Math.Floor(b));
            Console.WriteLine(Math.Ceiling(b));

            Console.WriteLine(Math.Min(b,c));

            double d = -7;
            Console.WriteLine(Math.Abs(b));
            Console.WriteLine(Math.Abs(d));

            double e = 0;
            Console.WriteLine(Math.Sign(b)); // b=50.9 -> 1 (positive)
            Console.WriteLine(Math.Sign(d)); // d = -7 -> -1 (negative)
            Console.WriteLine(Math.Sign(e)); // e = 0  -> 0 (zero)

            // Char Data Type
            //char letter1 = 'a';
            //string letter2 = "a";

            int number = '\t';
            Console.WriteLine(number);

            Console.WriteLine("Hello\tCaleb");

            char letter3 = (char)(65);
            Console.WriteLine(letter3);

            //String Data Type
            string name = "Avramescu";
            name += " Alexandra";
            Console.WriteLine(name);

            char[] characters = { 'h', 'e', 'l', 'l', 'o' };
            Console.WriteLine(characters);
            string greeting = new string(characters); //hello
            Console.WriteLine(greeting);

            string message = $"Hello my name is {name}, and I like to say {greeting}";
            Console.WriteLine(message);

            //String Properties
            string name2 = "Andrei";
            Console.WriteLine(name2.Length);
            Console.WriteLine(name2.CompareTo("Andrei"));
            //Console.WriteLine(name2.CompareTo("Briana"));
            int position = name2.CompareTo("Briana");
            Console.WriteLine(position);
            int position2 = name2.IndexOf("nd",2);
            Console.WriteLine(position2);

            Console.WriteLine(name2.Remove(1, 4));

            string name3 = "   \t\t\t\t\t Ale";
            Console.WriteLine(name3);
            Console.WriteLine(name3.Trim());

            string name4 = "Hello my name is Ale";
            string[] words = name4.Split(' ');
            Console.WriteLine(words[1]);
           
        }
    }
}
