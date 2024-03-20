using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            // https://youtu.be/0QUgvfuKvWU?t=21208
            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);
            System.IO.File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "This is the end of the page";
            return content;
        }
    } 
}
