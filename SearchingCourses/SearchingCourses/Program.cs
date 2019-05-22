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
            //var songLyrics = new SongLyrics("Shakira", "Nada");

            var profanityFinder = new ProfanityFinder("no, kurwa !");


           Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    class ProfanityFinder
    {
        public ProfanityFinder(string text)
        {
            var dictFile = File.ReadAllText("../profanities.");
        }
    }
}
