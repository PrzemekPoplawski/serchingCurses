using SearchingCurses;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {

            var Eminem = new Artist("Eminem");
            Eminem.songTitles = new List<string>()
            {
                "Lose Yourself",
                 "Not Afraid",
                "Sing for the Moment",
                "The Real Slim Shady",
                "Stan",
                "Rap God"
            };

            Eminem.CalculateSwearAndWordCount();

            Eminem.DisplayStatistic();

            var liroy = new Artist("Nicki Minaj");
            liroy.songTitles = new List<string>()
            {
                
                "Only",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"

            };
            liroy.CalculateSwearAndWordCount();
            liroy.DisplayStatistic();
            
           Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    
}
