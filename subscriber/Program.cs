using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;
string topic = "TopicB"; // one of "TopicA" or "TopicB"
using (var subSocket = new SubscriberSocket(">tcp://0.0.0.0:50551"))
{
    subSocket.Options.ReceiveHighWatermark = 1000;
    subSocket.Subscribe(topic);
    Console.WriteLine("Subscriber socket connecting...");
    while (true)
    {
        string messageTopicReceived = subSocket.ReceiveFrameString();
        string messageReceived = subSocket.ReceiveFrameString();
        Console.WriteLine(messageReceived);
    }
}