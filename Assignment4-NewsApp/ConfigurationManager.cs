using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp
{
    public static class ConfigurationManager
    {
        public static string GetApiKey()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ApiKey"]
                ?? throw new ArgumentException("Api Key not found!!");
        }

        public static string GetBaseUrl()
        {
            return System.Configuration.ConfigurationManager.AppSettings["BaseUrl"]
                ?? throw new ArgumentException("Api Url not found!!");
        }

        public static string GetCompleteApi() {

            var countryParameter = User.CountryParameter;
            var categoryParameter = User.CategoryParameter;

            if (countryParameter == "" && categoryParameter == "")
            {
                return GetBaseUrl() + "?q=general" + "&apiKey=" + GetApiKey();
            }else if(countryParameter == "" && categoryParameter != "")
            {
                return GetBaseUrl() + "?" + categoryParameter + "&apiKey=" + GetApiKey();
            }
            else if (countryParameter != "" && categoryParameter == "")
            {
                return GetBaseUrl() + "?" + countryParameter + "&apiKey=" + GetApiKey();
            }
            else
            {
                return GetBaseUrl() + "?" + countryParameter + "&" + categoryParameter + "&apiKey=" + GetApiKey();
            }
        }
    }
}
