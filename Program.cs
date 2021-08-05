using System;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
	    int x = 5;

            UDPSocket c = new UDPSocket();
            c.Client("162.255.85.127", 7777);
            c.Send("TEST!");

            Console.ReadKey();
        }
    }
}
