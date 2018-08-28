using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataTypesAndVaribales
{
    public partial class btn1 : Form
    {
        public btn1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string StringNumberValue;
            StringNumberValue = "12";

            string stringDateValue;
            stringDateValue = "Dec 12, 2013";

            string stringDoubleValue;
            stringDoubleValue = "12";

            int intTextValue;
            intTextValue = 12;

            MessageBox.Show("The result for Text to Number Conversion is:" + " "+ Convert.ToInt32(StringNumberValue));
            MessageBox.Show("The result for Text to Date Conversion is:" + " " + Convert.ToDateTime(stringDateValue));
            MessageBox.Show("The result for Text to Double Conversion is:" + " " + Convert.ToDecimal(stringDoubleValue));
            MessageBox.Show("The result for Number to Text Conversion is: " + " " + Convert.ToString(intTextValue));
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double budget = 12.10;
            const double expenses = 10.50;
            const string name = "[Martin]";
            const string address = "[Davao City]";
            const string age = "[20]";
            const bool answer = true;
            const int count = 12;
            double CashOnHand;
            bool BoolResult = answer;
            int CountResult;
            string Message;

            CashOnHand = budget - expenses;
            MessageBox.Show ("Hi!" + " "  + name + " " + "your Age is" + " " + age);
            MessageBox.Show ("There are" + " " + name.Count().ToString() + " " + "letters of your name.");
            MessageBox.Show ("Your name is " + " "+ name.ToUpper());
            MessageBox.Show ("Your name is " + " " + name.ToLower());
            MessageBox.Show (BoolResult.ToString());

            CountResult = count - 2;
            MessageBox.Show(Convert.ToString(CountResult));
            MessageBox.Show(Convert.ToString(CashOnHand));


        }
         
    }
}
