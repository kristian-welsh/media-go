using System;

namespace HelloThree
{
    public class NetworkLink
    {
        public void Connect()
        {
            var stream = new RTSPVideoStream();
            Console.WriteLine("connection established");
        }
    }
}

