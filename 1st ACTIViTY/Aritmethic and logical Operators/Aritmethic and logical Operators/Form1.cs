using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aritmethic_and_logical_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int f = 5;
            int result;

  

            result = a - b - c - d;
            MessageBox.Show(result.ToString());

            result = a - b + c - d; 
            MessageBox.Show(result.ToString());

            result = a + b / c / d;
            MessageBox.Show(result.ToString());

            result = a + b / c * d;
            MessageBox.Show(result.ToString());

            result = a / b * c * d;
            MessageBox.Show(result.ToString());

            result = a / b * c * d;
            MessageBox.Show(result.ToString());

            result = (a - (b - c)) - d;
            MessageBox.Show(result.ToString());

            result = a - ((b - c) - d);
            MessageBox.Show(result.ToString());
            
            result = a ^ (b * c) * d * f;
            MessageBox.Show(result.ToString());

            result = a + (b - c) * d - f;
            MessageBox.Show(result.ToString());

            result = f % b;
            MessageBox.Show(result.ToString());

            result = a++;
            MessageBox.Show(result.ToString());

            result = b--;
            MessageBox.Show(result.ToString());


            
            if (a == 1)
            {
                MessageBox.Show("a has a value of 1");
            }
             if (a != b)
            {
                MessageBox.Show("a is not eqaul to b");
            }
             if (a > 0)
            {
                MessageBox.Show("a is greater than zero");
            }
            if (a < b)
            {
                MessageBox.Show("a is less than b");
            }
            if (b >= 2)
            {
                MessageBox.Show("b is greater than or equa; to two");
            }
             if (a >= 1)
            {
                MessageBox.Show("a is greater than or equal to 1");
            }


             string name = String.Empty;
             string age = String.Empty;

             name = "Kevin";
             age = "18";

             if (name == "Kevin" && age == "18")
             {
                 MessageBox.Show("First is condition is true");
             }
             else
             {
                 MessageBox.Show("First Condition is false");
             }
             if (name == "Kevin" || age == "18")
             {
                 MessageBox.Show("Second Condiotion is true");
             }
             else
             {
                 MessageBox.Show("Second Condition is false");

             }
             if (!(name == "Kevin" && age == "18"))
             {
                 MessageBox.Show("Third condition is true");
             }
             else
             {
                 MessageBox.Show("Third Condition is false");
             }

                







            

            


                


        }
    }
}
