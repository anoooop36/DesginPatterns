using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    abstract class AbstractCircle
    {
        public IDraw drawTool;
        public AbstractCircle(IDraw drawTool)
        {
            this.drawTool = drawTool;
        }
        public abstract void Draw();
    }
}
