using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace HttpWebServer
{
    public class Server
    {

        private IPEndPoint _endPoint;

        private Socket _server;

        public Server(int port)
        {

            _endPoint = new IPEndPoint(IPAddress.Any, port);

        }

        public void Start()
        {

            _server = new Socket(SocketType.Stream, ProtocolType.Tcp);

            _server.Bind(_endPoint);

            _server.Listen(5);

        }


        public void Listen()
        {

            new Thread(_ =>
            {

                while (_server.IsBound)
                {

                    Console.WriteLine("Waiting for connection !!!");

                    Socket client = _server.Accept();

                    Console.WriteLine("Connected !!!");

                    new HandleRequest().RequestHandler(client);  

                    client.Close();

                }

            }).Start();
        }
    }
}
