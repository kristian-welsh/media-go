using System;
using static HelloThree.GraphicsLink;

namespace HelloThree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var graphics = new GraphicsLink();
            graphics.CreateWindow();
            Console.WriteLine("window was opened");
        }
    }
}

