using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SearchingCourses
{
    class ProfanityFinder
    {

        private string[] badwords;


        public ProfanityFinder()
        {
            


            var dictFile = File.ReadAllText("profanities.txt");
            dictFile = dictFile.Replace("*", "");
            dictFile = dictFile.Replace("(", "");
            dictFile = dictFile.Replace(")", "");
            badwords = dictFile.Split(new[] { "\",\"" },StringSplitOptions.None);
           
            
        }

      
        public string Censored(string text)
        {
            foreach(var word in badwords)
            {
                text = RemoveBadWord(text, word);
            }
            return text;
        }

        public int CountBadWords(string text)
        {
            int BadWordsAmount=0;

            foreach(var word in badwords)
            {
                if (text.Contains(word))
                {
                    BadWordsAmount++;
                }
                
            }

            return BadWordsAmount;
        }
        
        public Dictionary<string, int> FindTopBadWords(string lirycs)
        {
            var dict = new Dictionary<string, int>();

            foreach (var word in badwords)
            {
                int occurencesOfWord = CalacOccurencesof(word, lirycs);

                if (occurencesOfWord > 0)
                {
                    dict[word] = occurencesOfWord;
                }
            }
            return dict;

        }

        private int CalacOccurencesof(string word, string lirycs)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Matches(lirycs, pattern).Count;

           
        }

        private static string RemoveBadWord(string text, string word)
        {
            var pattern = "\\b" + word + "\\b";

            return Regex.Replace(text, pattern, "____",RegexOptions.IgnoreCase);
           
        }

        



        public string GetBadWordsSummary(Song song)
        {
            var summary = "";
            var badWordsAmount = FindTopBadWords(song.lyrics);

            foreach(var word in badWordsAmount.OrderByDescending(word=>word.Value))
            {
                summary=summary  +"\n "+ word.Value+ "\n "+ word.Key;
            }
            return summary;
        }

    }
}
