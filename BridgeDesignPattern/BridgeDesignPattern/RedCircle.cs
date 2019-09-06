using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    class RedCircle : IDraw
    {
        public void DrawLine()
        {
            Console.WriteLine("Drawn Red circle");
        }
    }
}
