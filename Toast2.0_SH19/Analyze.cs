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

    class TTweetList
    {
        public IEnumerable<TTweet> ttweets;
        //Aggrigate score
        public
            int
            size,
            joy,
            fear,
            anger,
            disgust,
            sadness,
            surprise;
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
                    if (word.Contains(emotion.e)) {
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
        public TTweetList AnalyzeList(IEnumerable<ITweet> tweets, IUser user)
        {
            var tempList = new TTweetList();
            var temp = new List<TTweet>();
            foreach (var item in tweets)
            {
                //Need to account for word and text lenght missing from TTWEET
                TTweet f = AnalyzeSingle(item);
                temp.Add(f);
                tempList.anger += f.anger;
                tempList.disgust += f.disgust;
                tempList.fear += f.fear;
                tempList.joy += f.joy;
                tempList.surprise += f.surprise;
                tempList.sadness += f.sadness;
                tempList.size++;
            }
            return tempList;
        }

        public Dictionary<string, double> getPersonalities(TTweetList _list)
        {
            var map = new Dictionary<string, double>();

            double joyN = (double)_list.joy / (double)_list.size;
            double fearN = (double)_list.fear / (double)_list.size;
            double angerN = (double)_list.anger / (double)_list.size;
            double disgustN = (double)_list.disgust / (double)_list.size;
            double sadnessN = (double)_list.sadness / (double)_list.size;
            double surpriseN = (double)_list.surprise / (double)_list.size;

            double neurotic = fearN * 0.5 + sadnessN * 0.9 + angerN * 0.5;
            double agreeable = joyN - disgustN * 0.5 - angerN * 0.4;
            double open = surpriseN - disgustN * 0.5 - fearN * 0.4 + joyN * 0.3;
            double extrovert = joyN * 0.7 + surpriseN * 0.6 - sadnessN * 0.4 - fearN * 0.3;
            double conscientious = joyN + disgustN * 0.8 - angerN * 0.2;

            if (neurotic < 0)
            {
                neurotic = 0;
            }
            if (agreeable < 0)
            {
                agreeable = 0;
            }
            if (open < 0)
            {
                open = 0;
            }
            if (extrovert < 0)
            {
                extrovert = 0;
            }
            if (conscientious < 0)
            {
                conscientious = 0;
            }

            double personalityTotal = neurotic + agreeable + open + extrovert + conscientious;

            map.Add("Neurotic", neurotic / personalityTotal);
            map.Add("Agreeable", agreeable / personalityTotal);
            map.Add("Open", open / personalityTotal);
            map.Add("Extrovert", extrovert / personalityTotal);
            map.Add("Conscientious", conscientious / personalityTotal);
            map.Add("Total", personalityTotal);

            return map;
        }
    }
}
