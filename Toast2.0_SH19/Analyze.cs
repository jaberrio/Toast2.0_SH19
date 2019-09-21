using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toast2._0_SH19
{
    class Analyze
    {
        IEnumerable<string> tweet;
        IEnumerable<string> user;
        public Analyze()
        {

        }
        public Analyze(IEnumerable<string> _tweet, IEnumerable<string> _user)
        {
            tweet = _tweet;
            user = _user;
        }
    }
}
