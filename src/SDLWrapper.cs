using System;
using System.Runtime.InteropServices;

namespace HelloThree
{
    public class SDLWrapper
    {
        private const string SDL2Library = "lib/SDL2.dll";
        //private const string SDL2Library = "lib/SDL2.so";


        // Import SDL functions using P/Invoke
        // todo: Add declarations for other SDL functions as needed
        [DllImport(SDL2Library, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDL_Init(int flags);

        public void SelfTest()
        {
            SDL_Init(0);
            /*
            if(SDL_Init(SDL.SDL_INIT_EVERYTHING) < 0)
            {
                Console.WriteLine($"SDL Initialization Error: {SDL.SDL_GetError()}");
                return;
            }
            SDL.SDL_Quit();
            */
        }
    }
}

