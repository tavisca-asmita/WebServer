using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;


namespace HttpWebServer
{
    public class HttpResponse
    {

        private const string _httpHeader = "HTTP/1.1";

        private string _contentType;

        private int _statusCode;

        private string _statusMessage;



        public HttpResponse(string contentType, int stausCode, string statusMessage)

        {

            _contentType = contentType;

            _statusCode = stausCode;

            _statusMessage = statusMessage;

        }



        public void SendResponse(Socket client, string fileData)

        {

            StringBuilder responseData = new StringBuilder();

            responseData.AppendLine(_httpHeader + " " + _statusCode + " " + _statusMessage);

            responseData.AppendLine("Content-Type: " + _contentType + ";charset=UTF-8");

            responseData.AppendLine();

            List<byte> response = new List<byte>();

            //Console.WriteLine(Encoding.UTF8.GetBytes(responseData.ToString()));

            response.AddRange(Encoding.UTF8.GetBytes(responseData.ToString()));

            //Console.WriteLine(Encoding.UTF8.GetBytes(fileData));

            response.AddRange(Encoding.UTF8.GetBytes(fileData));

            client.Send(response.ToArray());

        }

    }
}
