using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Tweetinvi;
using Tweetinvi.Models;
using System.Diagnostics;

namespace Toast2._0_SH19
{
    class oath
    {
        public oath()
        {
            var appCredentials = new TwitterCredentials("eGr9HEC4100Ru5ysWQC4JtODI ", "xsYHSKZ54y9cgl1zwq4L21FXgrAj5bzkMWjBk0BdLhLRyiiIiT ");
            var authenticationContext = AuthFlow.InitAuthentication(appCredentials);
            Process.Start(authenticationContext.AuthorizationURL);

            //var pinCode = dasds.text;
            //var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);
            //Auth.SetCredentials(userCredentials);


        }
    }
}
