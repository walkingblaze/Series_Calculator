using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Calculator.HelperLibrary
{
    public static class Extensions
    {
        public static string AddUserInput(this string messageString, string UserInput)
        {
            if(string.IsNullOrEmpty(messageString))
            {
                return string.Empty;
            }
            if (string.IsNullOrEmpty(UserInput))
            {
                return messageString;
            }
            return messageString.Replace("@@UserInput", UserInput);
        }
    }
}
