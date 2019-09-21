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
        public class subjectivity{
            public bool strong = false;
            public bool positive = false;

            public subjectivity(bool strong, bool positive)
            {
                this.strong = strong;
                this.positive = positive;
            }
        };
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
        public List<subjectivity> subjectivities;

        public enum positive { ALL = 2, POSITIVE = 1, NEGATIVE = 0};
        public enum strong { ALL = 2,STRONG = 1, WEAK = 0};

        public int getSubHits(positive p ,strong s)
        {
            int count = 0;
            foreach (var item in subjectivities)
            {
                //POSITIVE POSTIVE
                if (item.positive == true && (p == positive.POSITIVE || p == positive.ALL))
                {
                    if(item.strong == true  && (s == strong.STRONG  || s == strong.ALL))count++;
                    if(item.strong == false && (s == strong.WEAK    || s == strong.ALL))count++;
                }
                if (item.strong == false && (p == positive.NEGATIVE || p == positive.ALL))
                {
                    if (item.strong == true && (s == strong.STRONG || s == strong.ALL)) count++;
                    if (item.strong == false && (s == strong.WEAK || s == strong.ALL)) count++;
                }
            }
            return 0;
        }
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

            //Pulls out 6 emotionalChar of a tweet
            pullSixOut(words, temp);
            return temp;
        }

        //Updates the tweets score of the 6 traits based on emotions
        public void pullSixOut(string[] words, TTweet temp)
        {
            foreach (var word in words)
            {
                countWord(word);
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

            //Sort the world
            wordCountList = wordCountList.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return tempList;
        }

        private Dictionary<string, int> wordCountList = new Dictionary<string, int>();
        
        public void countWord(string word)
        {
            if (wordCountList.ContainsKey(word))
                wordCountList[word]++;
            else
                wordCountList[word] = 1;
            
        }
    
    
        public Dictionary<string, double> getPersonaities(TTweetList _list)
        {
            var map = new Dictionary<string, double>();

            double joyN = _list.joy / _list.size;
            double fearN = _list.fear / _list.size;
            double angerN = _list.anger / _list.size;
            double disgustN = _list.disgust / _list.size;
            double sadnessN = _list.sadness / _list.size;
            double surpriseN = _list.surprise / _list.size;
            
            return map;
        }
    }
}
