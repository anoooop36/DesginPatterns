using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Client
    {
        static public ISocket Socket;
        public static void Main(string[] args)
        {
            Socket = new Adapter(new Plug());
            Console.WriteLine(Socket.getInput());
            Console.ReadLine();
        }
    }
}
