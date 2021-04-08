using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace IderisBulkUpdater
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; private set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static void SetJWTAuthToken(string token)
        {
            ApiClient.DefaultRequestHeaders.Add("Authorization", token);            
        }
    }
}
