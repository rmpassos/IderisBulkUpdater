using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class JwtToken
    {
        public string TokenString { get; set; }

        public JwtToken(string tokenString)
        {
            TokenString = tokenString.Replace("\"", "");

        }
    }
}
