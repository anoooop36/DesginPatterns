using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    class GreenCircle: IDraw
    {
        public void DrawLine()
        {
            Console.WriteLine("Drawn green circle");
        }
    }
}
