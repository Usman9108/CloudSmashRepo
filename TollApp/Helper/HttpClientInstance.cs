using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollClassLibrary.Helper;

namespace TollApp.Helper
{
    public static class HttpClientInstance
    {
        private static HttpClient _client;

        private static object _lock = new object();

        public static HttpClient GetClient()
        {
            if (_client == null)
            {
                lock (_lock)
                {
                    if (_client == null)
                    {
                        _client = new HttpClient { BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiBaseUrl"]!) };
                        _client.DefaultRequestHeaders.Add(StringConstants.APIKEY, ConfigurationManager.AppSettings[StringConstants.APIKEY]!);
                    }
                }
            }
            return _client;
        }
    }

}
