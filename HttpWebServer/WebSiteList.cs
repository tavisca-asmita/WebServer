using System.Collections.Generic;
using System.Linq;

namespace HttpWebServer
{
    public class WebSiteList
    {
        private List<string> _websiteList;
        
        public WebSiteList()
        {
            _websiteList = new List<string>();
            _websiteList.Add("www.google.com");
            _websiteList.Add("www.yahoo.com");
            _websiteList.Add("www.tavisca.com");
            _websiteList.Add("www.testpage.com");
        }
        
        public bool CheckIfWebsiteExists(string url)
        {
            int flag = 0;
            foreach (var site in _websiteList)
            {
                if (url.Contains(site))
                {
                    flag = 1;
                    break;
                }                
            }

            if (flag == 1)
                return true;
            else
                return false;

        }
    }
}
