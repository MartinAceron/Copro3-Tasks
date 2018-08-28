using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_Control_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

     

        private void button1ShowResult_Click(object sender, EventArgs e)
        {
            string Gender = string.Empty;
            string Hobbies = string.Empty;
            string City = string.Empty;
            string civilStatus = String.Empty;


        if(radioButton1Male.Checked == true)
            {
                Gender = "Male";
            }
        else if(radioButton2Female.Checked == true)
            {
                Gender = "Female";
            }

         if(checkBox1Basketball.Checked == true)
            {
                Hobbies = Hobbies + "Basketball" + Environment.NewLine;
            }
        
          if(checkBox2WatchingTv.Checked == true)
            {
                Hobbies = Hobbies + "WatchingTV" + Environment.NewLine;
            }
           
          if(checkBox3Swimming.Checked == true)
            {
                Hobbies = Hobbies + "Swimming" + Environment.NewLine;
            } 

                City = cboCity.Text;
                CivilStatus = listBox1stCS.Text;
            
            MessageBox.Show("Full name:" + textFirstName.text + "" + textLastName.text + Environment.NewLine 
                + "Age:" + textAge + Environment.NewLine 
                + "Gender:" + Gender + Environment.NewLine
                + "ContactNo.:" + textContactNo.Text + Environment.NewLine)
                + "City:" + City + Environment.NewLine
                + "Civil Status" + listBox1stCS + Environment.NewLine
                + "Hobbies" + Hobbies,"Personal Info Summary");
        }

    }
}

