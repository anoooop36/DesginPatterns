using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    class Circle : AbstractCircle
    {
        public Circle(IDraw drawCircle) : base(drawCircle)
        {
        }
        public override void Draw()
        {
            drawTool.DrawLine();
        }
    }
}
