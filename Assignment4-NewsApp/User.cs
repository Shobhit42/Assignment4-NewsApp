using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp
{
    public class User
    {
        public static string CountryParameter { get; set; }
        public static string CategoryParameter { get; set; }

        public static void GetUserRequirements()
        {
            User.CountryParameter = GetCountry();
            if (User.CountryParameter != "" && User.CountryParameter != null)
            {
                User.CountryParameter = "country=" + User.CountryParameter;
            }

            User.CategoryParameter = GetCategory();
            if (User.CategoryParameter != "" && User.CategoryParameter != null)
            {
                User.CategoryParameter = "category=" + User.CategoryParameter;
            }
        }

        private static string GetCategory()
        {
            ConsoleHelper.DisplayCategoryOptions();

            int optionNumber = ConsoleHelper.GetInputInt();
            if (optionNumber == 1) return "business";
            else if (optionNumber == 2) return "entertainment";
            else if (optionNumber == 3) return "general";
            else return "";
        }
        public static string GetCountry()
        {
            ConsoleHelper.DisplayCountryOptions();

            int optionNumber = ConsoleHelper.GetInputInt();
            if (optionNumber == 1) return "in";
            else if (optionNumber == 2) return "us";
            else if (optionNumber == 3) return "cn";
            else return "";
        }
    }
}
