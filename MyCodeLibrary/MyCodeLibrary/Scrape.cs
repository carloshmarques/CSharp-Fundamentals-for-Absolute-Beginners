using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    // https://youtu.be/0QUgvfuKvWU?t=20675
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            
            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
           
            string reply = GetWebpage(url);
            File.WriteAllText(filepath, reply);
            return reply;
           
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }


    }
}
