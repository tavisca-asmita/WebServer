using System.IO;


namespace HttpWebServer
{
    public class WebsiteData
    {
        public string GetWebsiteData(string url)
        {
            string name = url.Split('.')[1];
            string path = "C:\\Users\\assharma\\source\\WebSites\\" + name + ".html";
            return File.ReadAllText(path);                       
        }

        public string GetErrorWebsiteData()
        {            
            string path = "C:\\Users\\assharma\\source\\WebSites\\Website\\index.html";
            return File.ReadAllText(path);
        }

    }
}
