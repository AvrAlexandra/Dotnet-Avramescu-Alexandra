using System;

namespace TutorialPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.FirstName = "Alexandra";
            class1.LastName = "Avramescu";
            Console.WriteLine(class1.FirstName + " " + class1.LastName);

            Console.WriteLine(class1.GetFullName());


        }
    }
}
