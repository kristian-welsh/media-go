using System;
using System.Threading.Tasks;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
//using SDL2;
using static HelloThree.Window;

namespace HelloThree
{
    public class GraphicsLink
    {
        public void CreateWindow()
        {
            /*
            Console.WriteLine("OpenTK setup started");
            using (var window = new Window(new Vector2i(800, 600), "LearnOpenTK tutorial"))
            {
                Console.WriteLine("window created");
                window.Run();
            }
            Console.WriteLine("window closed");
            */

            Console.WriteLine("testing SDL");
            var sdl = new SDLWrapper();
            sdl.SelfTest();
            Console.WriteLine("SDL test complete");
        }
    }
}

