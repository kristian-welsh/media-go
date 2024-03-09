using System;
using static HelloThree.GraphicsLink;

namespace HelloThree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var graphics = new GraphicsLink();
            var network = new NetworkLink();
            graphics.CreateWindow();
            Console.WriteLine("window was opened");
            network.Connect();
            Console.WriteLine("network was connected");
        }
    }
}

