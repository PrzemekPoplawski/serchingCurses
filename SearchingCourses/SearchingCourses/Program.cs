using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            var songLyrics = new SongLyrics("Eminem", "Without me");

            var profanityFinder = new ProfanityFinder();

            var Censored = profanityFinder.Censored(songLyrics.lyrics);
            Console.WriteLine(Censored);
           Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    class ProfanityFinder
    {

        private string[] badwords;


        public ProfanityFinder()
        {
            


            var dictFile = File.ReadAllText("../profanities.txt");
            dictFile = dictFile.Replace("*", "");
            badwords = dictFile.Split(new[] { "\",\"" },StringSplitOptions.None);
           
            
        }

         public string Censored(string text)
        {
            foreach(var word in badwords)
            {
                text = text.Replace(" "+word+" ", " ___ ");
            }
            return text;
        }
    }
}
