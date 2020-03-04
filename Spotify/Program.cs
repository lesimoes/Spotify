using System;
using System.IO;
using System.Net;
using System.Text;

namespace Spotify
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string url = "https://api.myjson.com/bins/14bgg6";
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            System.IO.StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            Console.WriteLine(result);
            


        }
    }
}
