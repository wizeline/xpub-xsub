using System;
using System.IO;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;
using (var pubSocket = new PublisherSocket(">tcp://52.226.202.234:50552"))
{
    Console.WriteLine("Publisher socket connecting...");
    pubSocket.Options.SendHighWatermark = 1000;

    while (true)
    {
        TextReader tIn = Console.In;
        TextWriter tOut = Console.Out;
        tOut.Write("Escribe tu mensaje: ");
        String msg = tIn.ReadLine();
        Console.WriteLine("Sending message : {0}", msg);
        pubSocket.SendMoreFrame("TopicB").SendFrame(msg);
        
    }
}