using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;


namespace Toast2._0_SH19
{
    class LogicStepper
    {
        ITwitterCredentials appCreds = Auth.SetApplicationOnlyCredentials("eGr9HEC4100Ru5ysWQC4JtODI", "xsYHSKZ54y9cgl1zwq4L21FXgrAj5bzkMWjBk0BdLhLRyiiIiT", true);
        public IUser us;

        public LogicStepper(String name)
        {
            us = User.GetUserFromScreenName(name);
        }

        public IEnumerable<ITweet> getTweets()
        {
            var utp = new UserTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = 200
            };

            return Timeline.GetUserTimeline(us, utp);
        }

        public Image getPicture()
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(us.ProfileImageUrlFullSize);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}
