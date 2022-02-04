using NetMQ;
using NetMQ.Sockets;
    using (var xpubSocket = new XPublisherSocket("@tcp://*:50551"))
    using (var xsubSocket = new XSubscriberSocket("@tcp://*:50552"))
    {
        Console.WriteLine("Intermediary started, and waiting for messages");
        // proxy messages between frontend / backend
        var proxy = new Proxy(xsubSocket, xpubSocket);
        // blocks indefinitely
        proxy.Start();
    }

