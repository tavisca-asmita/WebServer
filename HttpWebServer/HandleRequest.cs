using System.Text;
using System.Net.Sockets;


namespace HttpWebServer
{
    public class HandleRequest
    {
               

        private WebsiteData _websiteDisplay;
        
        private Dispatcher _dispatcher;
        
        public HandleRequest()

        {
            _websiteDisplay = new WebsiteData();
                    
            _dispatcher = new Dispatcher();
                        
        }

        public void RequestHandler(Socket client)
        {

            NetworkStream stream = new NetworkStream(client);
                       
            byte[] streamData = new byte[1024];

            int requestDataLength = stream.Read(streamData, 0, streamData.Length);

            string requestData = Encoding.ASCII.GetString(streamData);
                                    
            _dispatcher.CheckExistence(client, requestData); 
            
            stream.Close();

        }

    }
}
