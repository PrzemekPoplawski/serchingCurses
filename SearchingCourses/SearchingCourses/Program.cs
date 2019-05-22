using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            var songLyrics = new SongLyrics("Shakira", "Nada");

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

     class SongLyrics
    {
        public SongLyrics(string artist, string title)
        {
            var browser = new WebClient();
            var url = "http://api.lyrics.ovh/v1/" + artist + "/" + title;
            var json = browser.DownloadString(url);
            Console.WriteLine(json);
        }
    }
}
