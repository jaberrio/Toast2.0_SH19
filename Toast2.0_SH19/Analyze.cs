using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace Toast2._0_SH19
{
    class TTweet
    {
        public
            int 
            joy,
            fear,
            anger,
            disgust,
            sadness,
            surprise;
        public ITweet t;
        public int numWords;
    }

    class wordE
    {
        public string e;
        public string word;
        public wordE(string e, string word)
        {
            this.e = e;
            this.word = word;
        }
        
    }

    class Analyze
    {
        List<wordE> wordEs;

        public Analyze()
        {
            wordEs = new List<wordE>(1000);
            string line;
            StreamReader file = new System.IO.StreamReader("DataClassify/emotions.csv");
            while ((line = file.ReadLine()) != null)
            {
                var s = line.Split(',');
                wordEs.Add(new wordE(s[0], s[1]));
            }
        }

        public TTweet AnalyzeSingle(ITweet tweet)
        {
            TTweet temp = new TTweet();
            temp.t = tweet;
            string[] words = tweet.Text.Split(' ');
            temp.numWords = words.Length;

            foreach (var word in words)
            {
                foreach (var emotion in wordEs)
                {
                    if (word.Contains(emotion.e)){
                        switch (emotion.word)
                        {
                            case "joy":
                                temp.joy++;
                                break;
                            case "anger":
                                temp.anger++;
                                break;
                            case "surprise":
                                temp.surprise++;
                                break;
                            case "disgust":
                                temp.disgust++;
                                break;
                            case "fear":
                                temp.fear++;
                                break;
                            case "sadness":
                                temp.sadness++;
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                }
            }
            return temp;
        }
        public IEnumerable<TTweet> AnalyzeList(IEnumerable<ITweet> tweets, IUser user)
        {
            var temp = new List<TTweet>();
            foreach (var item in tweets)
            {
                temp.Add(AnalyzeSingle(item));
            }
            return temp;
        }
    }
}
