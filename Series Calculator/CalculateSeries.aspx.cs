using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Series_Calculator.Entity;
using Series_Calculator.BusinessLogic;
using Series_Calculator.HelperLibrary;

namespace Series_Calculator
{
    public partial class CalculateSeries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_generateSeries_Click(object sender, EventArgs e)
        {
            Int64 UserInput = 0;

            
            ClearFields();

            // Check if the user input is empty or not
            if (string.IsNullOrEmpty(txt_userInput.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "bootbox.alert('" + StringConstants.TextBoxEmptyMessage + "');", true);
                return;
            }

            // Check if the user input is a number
            if (!Int64.TryParse(txt_userInput.Text, out UserInput))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "bootbox.alert('" + StringConstants.IncorrectTextMessage + "');", true);
                return;
            }

            // Check if the user input is a positive number
            if (Int64.TryParse(txt_userInput.Text, out UserInput))
            {
                if (UserInput < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "bootbox.alert('" + StringConstants.WholeNumberMessage + "');", true);
                    return;
                }
            }


            OutputResult Result = Instance_OutputResult;

            Result = Logic.Series1(UserInput);
            if (Result.OutputStatus == Status.Success)
            {
                lb_Series1.Text = StringConstants.Series1Label.AddUserInput(txt_userInput.Text);
                lt_Series1.Text = string.Join(", ", ((List<Int64>)Result.Result));
            }
            else
            {
                lb_Series1.Text = string.Empty;
                lt_Series1.Text = string.Empty;
            }

            Result = Logic.Series2(UserInput);
            if (Result.OutputStatus == Status.Success)
            {
                lb_Series2.Text = StringConstants.Series2Label.AddUserInput(txt_userInput.Text);
                lt_Series2.Text = string.Join(", ", ((List<Int64>)Result.Result));
            }
            else
            {
                lb_Series2.Text = string.Empty;
                lt_Series2.Text = string.Empty;
            }

            Result = Logic.Series3(UserInput);
            if (Result.OutputStatus == Status.Success)
            {
                lb_Series3.Text = StringConstants.Series3Label.AddUserInput(txt_userInput.Text);
                lt_Series3.Text = string.Join(", ", ((List<Int64>)Result.Result));
            }
            else
            {
                lb_Series3.Text = string.Empty;
                lt_Series3.Text = string.Empty;
            }

            Result = Logic.Series4(UserInput);
            if (Result.OutputStatus == Status.Success)
            {
                lb_Series4.Text = StringConstants.Series4Label.AddUserInput(txt_userInput.Text);
                lt_Series4.Text = string.Join(", ", ((List<string>)Result.Result));
            }
            else
            {
                lb_Series4.Text = string.Empty;
                lt_Series4.Text = string.Empty;
            }

            Result = Logic.Series5(UserInput);
            if (Result.OutputStatus == Status.Success)
            {
                lb_Series5.Text = StringConstants.Series5Label.AddUserInput(txt_userInput.Text);
                lt_Series5.Text = string.Join(", ", ((List<Int64>)Result.Result));
            }
            else
            {
                lb_Series5.Text = string.Empty;
                lt_Series5.Text = string.Empty;
            }
        }

        /// <summary>
        /// Clear the previous shown labels and literals if the user input is wrong
        /// </summary>
        void ClearFields()
        {
            lb_Series1.Text = string.Empty;
            lt_Series1.Text = string.Empty;
            lb_Series2.Text = string.Empty;
            lt_Series2.Text = string.Empty;
            lb_Series3.Text = string.Empty;
            lt_Series3.Text = string.Empty;
            lb_Series4.Text = string.Empty;
            lt_Series4.Text = string.Empty;
            lb_Series5.Text = string.Empty;
            lt_Series5.Text = string.Empty;
        }

        OutputResult Instance_OutputResult
        {
            get
            {
                return new OutputResult();
            }
        }

    }
}
