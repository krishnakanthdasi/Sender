using NetMQ;
using NetMQ.Sockets;
using System;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = new ResponseSocket("@tcp://localhost:5500");

            string message = socket.ReceiveFrameString();
            Console.WriteLine("Message : " + message);

            

        }
    }
}
