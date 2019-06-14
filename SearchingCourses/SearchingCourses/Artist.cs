using System;
using System.Collections.Generic;

namespace SearchingCourses
{
    public class Artist
    {

       public int wordsAmount;
        public int swearCount;


        public string name;
        public List<string> songTitles;

        public Artist(string name)
        {
            this.name = name;
        }

        public void CalculateSwearAndWordCount()
        {
            wordsAmount = 0;
            swearCount = 0;

            ProfanityFinder pf = new ProfanityFinder();

            foreach (var songTitle in songTitles)
            {
                var song = new Song(name, songTitle);

                 swearCount += pf.CountBadWords(song.lyrics);
                wordsAmount += song.CountWords();
                
            }
        }

        public void DisplayStatistic()
        {
            int profanityIndex= wordsAmount / swearCount;

            Console.WriteLine("Dla artysty:" + name + " co " + profanityIndex+ " słowo to przeklanstwo");
        }


    }
}