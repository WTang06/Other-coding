using System;

namespace VolumeCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the volume of a box.");

            Console.Write("Enter the length in cm: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width in cm: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height in cm: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = length * width * height;

            Console.WriteLine("The volume of a {0} cm x {1} cm x {2} cm box is {3} cubic metres.", length, width, height, volume);






        }
    }
}
