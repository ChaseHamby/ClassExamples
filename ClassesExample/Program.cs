using System;

namespace ClassesExample // Namespace // Used just like a component in React
{
    class Program // Class
    {
        //private string _myStuff = "for me"; 

        //string _myData = "this is just for me to use"; // Field // convention is to underscore then camelCase

        //public int Number { get; set; } // Property // you can set the value of this property and get the value // 'autoproperty'

        //public void DoTheThing()
        //{
        //    Number = 1;
        //    var x = Number;
        //}

        static void Main(string[] args)
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "I kinda liked it.");

            Console.WriteLine(taffy);

            Console.WriteLine("Hello World!"); // Method // Used to take an action
        }
    }
}
