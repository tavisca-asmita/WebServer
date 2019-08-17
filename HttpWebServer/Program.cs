using System.Threading;
using System.Threading.Tasks;

namespace HttpWebServer
{
    class Program
    {
        public static void Main(string[] args)
        {

            Server webServer = new Server(34567);

            Thread serverThread = new Thread(new ThreadStart(() =>

            {

                webServer.Start();

                webServer.Listen();

            }));

            serverThread.Start();

        }
    }
}
