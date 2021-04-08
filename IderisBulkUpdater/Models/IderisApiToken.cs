using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class IderisApiToken
    {
        public string Login_token { get; private set; }

        public IderisApiToken(string token)
        {
            Login_token = token;
        }
    }
}
