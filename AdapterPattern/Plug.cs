using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Plug
    {
        private string Specification;
        public string getInput()
        {
            return Specification;
        }

        public Plug()
        {
            Specification = "3-pin";
        }
    }
}
