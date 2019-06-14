using Newtonsoft.Json;
using SearchingCurses;
using System;
using System.Net;

namespace SearchingCourses
{
    public class Song
    {
        public string artist;
        public string title;
        public string lyrics;


        public Song(string artist, string title)
        {
           
            var url = "http://api.lyrics.ovh/v1/" + artist + "/" + title;
            var json = WebCache.GetOrDownload(url);


            var answe = JsonConvert.DeserializeObject<LyricsOvhAnswer>(json);
            lyrics = answe.lyrics;
           
            this.artist=artist;
            this.title=title;
            


        }

        public int CountWords()
        {
            return lyrics.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
