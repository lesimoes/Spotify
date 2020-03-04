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
            string user = "paulovermei";
            string url = $"https://api.spotify.com/v1/users/{user}/playlists";
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);

            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";
            webrequest.Accept = "application/json";
            webrequest.Headers.Add("Authorization", "Bearer " + "BQAJzuz1VxsZJkaDJk13XpPiRZGICLxkDQlTSi21Ni765YM0QPQ5GBABK5ShuLn0uS-GsQ9b0083NZ-z3OBs-ZVHsQ_7euBzINp_fEFmPJD9JSXPkM6V0HWiJ_FsBRh97i9Athf0m7IV-_3iVkLv0rUE1lu--vUq3PUFSZ0S-dd9ZJGHwzm6emKAvZcY9pkoMwqSRTa0EcjuH6kDzN0vW72NKpCjg94");

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
