using System;
using System.IO;

namespace VolumeCalculator_Improved_
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("box_data.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split(',');

                int length = Convert.ToInt32(parts[1]);
                int width = Convert.ToInt32(parts[2]);
                int height = Convert.ToInt32(parts[3]);

                int volume = length * width * height;

                writer.WriteLine("The volume of the box is {0}", volume);

            }

            reader.Close();
            writer.Close();
        }
    }
}
