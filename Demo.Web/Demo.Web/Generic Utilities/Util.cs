using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Demo.Web.Generic_Utilities
{
    public static class Util
    {
        public static string GetConfigData(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }
    }
}