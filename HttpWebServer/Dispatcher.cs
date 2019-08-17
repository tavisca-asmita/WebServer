using System.Net.Sockets;


namespace HttpWebServer
{
    public class Dispatcher
    {
        HttpResponse response;

        string responseData;
        
        private bool _flag = false;
        public void CheckExistence(Socket client, string url)
        {
            _flag = new WebSiteList().CheckIfWebsiteExists(url); 
            if(_flag == true)
            {
                responseData = new WebsiteData().GetWebsiteData(url);

                response = new HttpResponse("text/html", 200, "OK");
                                                                
            }
            else
            {
                responseData = new WebsiteData().GetErrorWebsiteData();

                response = new HttpResponse("text/html", 404, "Page Not Found");
            }

            response.SendResponse(client, responseData);
        }                
    }
}
