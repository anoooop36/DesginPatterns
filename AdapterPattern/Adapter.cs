using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Adapter : ISocket
    {
        private Plug _plug;

        public Adapter(Plug plug)
        {
            _plug = plug;
        }
        public string getInput()
        {
            return _plug.getInput()+ " power converted to 2 pin ";
        }
    }
}
