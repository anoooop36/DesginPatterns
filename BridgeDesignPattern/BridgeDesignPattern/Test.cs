using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    class Test
    {
        
        public static void Main()
        {
            AbstractCircle redCircle = new Circle(new RedCircle());
            redCircle.Draw();
            AbstractCircle greenCircle = new Circle(new GreenCircle());
            greenCircle.Draw();
            Console.ReadKey();
        }
    }
}
