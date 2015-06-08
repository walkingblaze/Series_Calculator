using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Calculator.HelperLibrary
{
    public static class StringConstants
    {
        public const string Series1Label = "All numbers upto @@UserInput and including @@UserInput";

        public const string Series2Label = "All odd numbers upto @@UserInput and including @@UserInput (If applicable)";

        public const string Series3Label = "All even numbers upto @@UserInput and including @@UserInput (If applicable)";

        public const string Series4Label = "All numbers upto @@UserInput and including @@UserInput<br />"
            + "Except when :<br />"
            + "a number is multiple of 3 output C<br />"
            + "a number is multiple of 5 output E<br />"
            + "a number is multiple of 3 and 5 output Z";

        public const string Series5Label = "All fibonacci numbers upto @@UserInput and including @@UserInput (If applicable)";

        public const string TextBoxEmptyMessage = "Please enter a number";
        public const string IncorrectTextMessage = "Entered text should be a number";
        public const string WholeNumberMessage = "Please enter a positive number";
    }
}
