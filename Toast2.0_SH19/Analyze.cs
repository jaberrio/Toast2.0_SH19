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

        public positive pos;
        public strong str;
        public int getSubHits(positive p ,strong s)
        {
            int count = 0;
            foreach (var item in subjectivities)
            {
                //POSITIVE POSITIVE
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
            return count;
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

    class wordSb
    {
        public string word;
        public string subj;
        public string posneg;

        public wordSb(string word, string subj, string posneg)
        {
            this.word = word;
            this.subj = subj;
            this.posneg = posneg;
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
        public
            double 
            tweetLength,
            positivity; //How positive a persons tweets are
    }

    class Analyze
    {
        List<wordE> wordEs;
        List<wordSb> wordSbs;

        public Analyze()
        {
            wordEs = new List<wordE>(1000);
            wordSbs = new List<wordSb>(1000);

            string line;
            StreamReader file = new System.IO.StreamReader("DataClassify/emotions.csv");
            while ((line = file.ReadLine()) != null)
            {
                var s = line.Split(',');
                wordEs.Add(new wordE(s[0], s[1]));
            }

            file = new System.IO.StreamReader("DataClassify/subjectivity.csv");
            while ((line = file.ReadLine()) != null)
            {
                var s = line.Split(',');
                wordSbs.Add(new wordSb(s[0],s[1],s[2]));
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
            pullSubjectiviityOut(words, temp);
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
                    if (word.Equals(emotion.e,StringComparison.OrdinalIgnoreCase)) {
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
        
        public void pullSubjectiviityOut(string[] words, TTweet temp)
        {
            temp.subjectivities = new List<TTweet.subjectivity>();

            foreach (var tweet_word in words)
            {
                foreach (var word_dic in wordSbs)
                {
                    if (tweet_word.Equals(word_dic.word,StringComparison.OrdinalIgnoreCase))
                    {
                        temp.pos = (word_dic.posneg.Equals("positive",StringComparison.OrdinalIgnoreCase)) ? TTweet.positive.POSITIVE : TTweet.positive.NEGATIVE;
                        temp.str = (word_dic.posneg.Equals("strongsubj",StringComparison.OrdinalIgnoreCase)) ? TTweet.strong.STRONG : TTweet.strong.WEAK;

                        TTweet.subjectivity tempSub = new TTweet.subjectivity(true, true);
                        if (temp.pos == TTweet.positive.POSITIVE)
                        {
                            if (temp.str == TTweet.strong.STRONG)
                            {
                                tempSub.positive = true;
                                tempSub.strong = true;
                            }
                            else if (temp.str == TTweet.strong.WEAK)
                            {
                                tempSub.positive = true;
                                tempSub.strong = false;
                            }
                        }
                        else if (temp.pos == TTweet.positive.NEGATIVE)
                        {
                            if (temp.str == TTweet.strong.STRONG)
                            {
                                tempSub.positive = false;
                                tempSub.strong = true;
                            }
                            else if (temp.str == TTweet.strong.WEAK)
                            {
                                tempSub.positive = false;
                                tempSub.strong = false;
                            }
                        }

                        temp.subjectivities.Add(tempSub);
                        break;
                    }
                }
            }
        }


        private TTweetList AnalyzeList(IEnumerable<ITweet> tweets, IUser user)
        {
            var tempList = new TTweetList();
            var temp = new List<TTweet>();

            int tweetCounter = 0;
            int wordCounter = 0;

            double tempPos = 0;
            double tempNeg = 0;

            foreach (var item in tweets)
            {
                //Need to account for word and text lenght missing from TTWEET
                TTweet f = AnalyzeSingle(item);
                temp.Add(f);

                tempPos += f.getSubHits(TTweet.positive.POSITIVE, TTweet.strong.ALL);
                tempNeg += f.getSubHits(TTweet.positive.NEGATIVE, TTweet.strong.ALL);
         
                wordCounter += f.numWords;
                tempList.anger += f.anger;
                tempList.disgust += f.disgust;
                tempList.fear += f.fear;
                tempList.joy += f.joy;
                tempList.surprise += f.surprise;
                tempList.sadness += f.sadness;
                tweetCounter++;
            }

            if (tweetCounter != 0)
            {
                tempList.tweetLength = wordCounter / tweetCounter;
                tempPos = tempPos / tweetCounter;
                tempNeg = tempNeg / tweetCounter;
            }

            tempList.positivity = tempPos - tempNeg;

            tempList.size = 
                tempList.anger + tempList.disgust + tempList.fear + tempList.joy + tempList.surprise + tempList.sadness;

            //Sort the world
            wordCountList = wordCountList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            
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
    
    
        public Dictionary<string, double> getPersonaities(IEnumerable<ITweet> tweets, IUser user)
        {
            var _list = AnalyzeList(tweets, user);
            var map = new Dictionary<string, double>();

            double joyN =       Math.Round((((double)_list.joy        / (double)_list.size)*0.40d),3)*100;
            double fearN =      Math.Round((((double)_list.fear       / (double)_list.size)*0.88d),3)*100;
            double angerN =     Math.Round((((double)_list.anger      / (double)_list.size)*0.98d),3)*100;
            double disgustN =   Math.Round((((double)_list.disgust    / (double)_list.size)*0.84d),3)*100;
            double sadnessN =   Math.Round((((double)_list.sadness    / (double)_list.size)*0.57d),3)*100;
            double surpriseN =  Math.Round((((double)_list.surprise   / (double)_list.size)*0.86d),3)*100;

            map.Add("Joy",joyN);
            map.Add("Fear", fearN);
            map.Add("Anger", angerN);
            map.Add("Disgust", disgustN);
            map.Add("Sadness", sadnessN);
            map.Add("Surprise", surpriseN);

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

            map.Add("Neurotic",       (Math.Round((double)neurotic      / (double)personalityTotal, 3) * 100));
            map.Add("Agreeable",      (Math.Round((double)agreeable     / (double)personalityTotal, 3) * 100));
            map.Add("Open",           (Math.Round((double)open          / (double)personalityTotal, 3) * 100));
            map.Add("Extrovert",      (Math.Round((double)extrovert     / (double)personalityTotal, 3) * 100));
            map.Add("Conscientious",  (Math.Round((double)conscientious / (double)personalityTotal, 3) * 100));
            map.Add("Total",          (Math.Round((double)personalityTotal, 2) * 100));

            return map;
        }

        public double getPositivity(TTweetList _list)
        {
            return _list.positivity;
        }
    }
}
