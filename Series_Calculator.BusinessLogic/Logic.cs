using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series_Calculator.Entity;

namespace Series_Calculator.BusinessLogic
{
    public static class Logic
    {

        // Calculate the series 
        // up to and including 
        // the number entered by user
        public static OutputResult Series1(Int64 userInput)
        {
            OutputResult Output = new OutputResult();
            try
            {
                List<Int64> Result = new List<Int64>();

                for (int i = 0; i <= userInput; i++)
                {
                    Result.Add(i);
                }

                Output.Result = Result;
                Output.OutputStatus = HelperLibrary.Status.Success;
            }
            catch 
            {
                Output.OutputStatus = HelperLibrary.Status.Error;
            }
            return Output;


        }

        public static OutputResult Series2(Int64 userInput)
        {
            OutputResult Output = new OutputResult();
            List<Int64> Result = new List<Int64>();

            for (int i = 0; i <= userInput; i++)
            {
                if (i % 2 != 0)
                {
                    Result.Add(i);
                }
            }

            Output.Result = Result;
            Output.OutputStatus = HelperLibrary.Status.Success;
            return Output;
        }

        public static OutputResult Series3(Int64 userInput)
        {
            OutputResult Output = new OutputResult();
            List<Int64> Result = new List<Int64>();

            for (int i = 0; i <= userInput; i++)
            {
                if (i % 2 == 0)
                {
                    Result.Add(i);
                }
            }

            Output.Result = Result;
            Output.OutputStatus = HelperLibrary.Status.Success;
            return Output;
        }

        public static OutputResult Series4(Int64 userInput)
        {
            OutputResult Output = new OutputResult();
            List<string> Result = new List<string>();

            for (int i = 0; i <= userInput; i++)
            {

                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Result.Add("Z");
                    }
                    else
                    {
                        Result.Add("C");
                    }
                }
                else if (i % 5 == 0)
                {
                    Result.Add("E");
                }
                else
                {
                    Result.Add(i.ToString());
                }

            }

            Output.Result = Result;
            Output.OutputStatus = HelperLibrary.Status.Success;
            return Output;
        }

        public static OutputResult Series5(Int64 userInput)
        {
            OutputResult Output = new OutputResult();
            List<Int64> Result = new List<Int64>();

            int FibNumber = 1;
            int Init = 0;
            int Swap = 1;

            while (true)
            {
                FibNumber = Init + Swap;
                Init = Swap;
                Swap = FibNumber;

                if (FibNumber > userInput)
                {
                    break;
                }
                Result.Add(FibNumber);
            }

            Output.Result = Result;
            Output.OutputStatus = HelperLibrary.Status.Success;
            return Output;
        }

    }
}
